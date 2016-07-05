// ------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Atalasoft.Annotate;
using Atalasoft.Annotate.Icons;
using Atalasoft.Annotate.UI;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Pdf;
using Atalasoft.Imaging.WinControls;

namespace Atalasoft.Demo.AnnotationViewer
{
    /// <summary>
    /// Main application form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields

        private readonly AnnotationDefaults _defaultAnnotations = new AnnotationDefaults();
        private string _currentFile = string.Empty;
        private ImageList _annotationImages;

        #endregion Fields

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadAnnotationToolbarImages();
            EnableDisableMenuAndToolbarItems();
            WinDemoHelperMethods.PopulateDecoders(RegisteredDecoders.Decoders);

            annotationViewer.SelectedIndexChanged += AnnotationViewerSelectedIndexChanged;
            annotationViewer.Annotations.SelectionChanged += AnnotationViewer_Annotations_SelectionChanged;
            annotationViewer.Annotations.Rotated += AnnotationViewer_AnnotationRotated;
            annotationViewer.Annotations.Resized += AnnotationViewer_AnnotationResized;
            annotationViewer.Annotations.Moved += AnnotationViewer_AnnotationMoved;
            annotationViewer.Annotations.AnnotationCreated += AnnotationViewer_AnnotationCreated;

            annotationViewer.SelectFirstPageOnOpen = true;
            annotationViewer.Annotations.ClipToDocument = true;
        }

        #region ImageControl Event Handlers

        private void AnnotationViewerSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        #endregion ImageControl Event Handlers

        #region Annotation Event Handlers

        private void RubberStampTool_Click(object sender, EventArgs e)
        {
            var stamp = (RubberStampAnnotation)_defaultAnnotations.GetAnnotation(AnnotationType.RubberStamp);
            stamp.Text = ((ToolStripMenuItem)sender).Text;
            annotationViewer.Annotations.CreateAnnotation(stamp, CreateAnnotationMode.SingleClickCenter);
        }

        private void AnnotationViewer_Annotations_SelectionChanged(object sender, EventArgs e)
        {
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_AnnotationMoved(object sender, AnnotationEventArgs e)
        {
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_AnnotationResized(object sender, AnnotationEventArgs e)
        {
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_AnnotationRotated(object sender, AnnotationEventArgs e)
        {
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_UndoListChanged(object sender, EventArgs e)
        {
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_AnnotationCreated(object sender, AnnotationEventArgs e)
        {
            var txt = e.Annotation as TextAnnotation;
            if (txt != null)
                txt.EditMode = true;

            var ca = e.Annotation as CalloutAnnotation;
            if (ca != null)
                ca.EditMode = true;

            e.Annotation.Selected = true;
            e.Annotation.ContextMenuStrip = contextMenuStrip1;
            EnableDisableMenuAndToolbarItems();
        }

        private void AnnotationViewer_SelectionRectangleChanged(object sender, RubberbandEventArgs e)
        {
            var rc = annotationViewer.ImageControl.Selection.Bounds;
            var selectionBounds = new RectangleF(rc.X, rc.Y, rc.Width, rc.Height);
            SwitchAnnotationAuthorMode(true);
            annotationViewer.Annotations.SelectFromBounds(selectionBounds, true);
        }

        #endregion Annotation Event Handlers

        #region Misc Methods

        private void OpenImageFile()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = WinDemoHelperMethods.CreateDialogFilter(true);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    annotationViewer.Open(dlg.FileName, -1);
                    _currentFile = dlg.FileName;
                }
            }

            if (annotationViewer.Count > 0)
            {
                UpdateStatusBar();
            }

            EnableDisableMenuAndToolbarItems();
        }

        /// <summary>
        /// Updates the page x of y and file name items on the statusbar
        /// </summary>
        private void UpdateStatusBar()
        {
            // We could probably just force this to 1, but to be safe, let's keep it dynamic
            var currentPage = 0;
            var selectedIndicies = annotationViewer.ThumbnailControl.SelectedIndicies;

            if (selectedIndicies.Length > 0)
                currentPage = selectedIndicies[0] + 1;

            toolStripStatusPage.Text = string.Format("Page {0} of {1}", currentPage, annotationViewer.Count);
            toolStripStatusFile.Text = Path.GetFileName(_currentFile);
        }

        /// <summary>
        /// When called without a fileName, 
        /// we provide a SaveFileDialog, then pass along to the version that takes a fileName
        /// </summary>
        private void SaveImageFile()
        {
            using (var dlg = new SaveFileDialog())
            {
                dlg.Filter = WinDemoHelperMethods.CreateDialogFilter(false);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // slight change from the video...
                    SaveImageFile(dlg.FileName);
                    _currentFile = dlg.FileName;
                    UpdateStatusBar();
                }
            }
        }

        /// <summary>
        /// Performs the file save... note that annotations are automatically embedded 
        /// if the target encoder supports embedded annotations
        /// </summary>
        /// <param name="fileName">File name.</param>
        private void SaveImageFile(string fileName)
        {
            var enc = GetEncoder(Path.GetExtension(fileName));

            if (enc != null)
                annotationViewer.Save(fileName, enc);
            else
                MessageBox.Show("unable to determine correct encoder for file: " + fileName);
        }

        /// <summary>
        /// Examines the file extension on fileName to return the correct ImageEncoder.
        /// </summary>
        /// <param name="fileName">Name of the file to examine.</param>
        /// <returns><see cref="ImageEncoder"/> instance that can be used to encode specified file.</returns>
        private ImageEncoder GetEncoder(string fileName)
        {
            string ext = Path.GetExtension(fileName);

            ImageEncoder returnEnc = null;

            if (ext != null)
            {
                switch (ext.ToLower())
                {
                    case ".tif":
                    case ".tiff":
                        returnEnc = new TiffEncoder();
                        break;
                    case ".pdf":
                        returnEnc = new PdfEncoder();
                        break;
                }
            }

            return returnEnc;
        }

        /// <summary>
        /// Cleans up the annotations/images and undoes to let go of the current file.
        /// </summary>
        private void CloseCurrentFile()
        {
            annotationViewer.Clear();
            annotationViewer.Annotations.UndoManager.Clear();
        }

        /// <summary>
        /// Used by the EmbeddedImageAnnotation and ReferencedImageAnnotation creation methods to get the filename to use.
        /// </summary>
        /// <returns>Image file name.</returns>
        private string GetFilename()
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = @"Images|*.jpg;*.png;*.tif;*.tiff;*.bmp;*.emf;*.wmf;*.gif";
                return dlg.ShowDialog(this) == DialogResult.OK ? dlg.FileName : null;
            }
        }

        /// <summary>
        /// When printing, DocumentAnnotationViewer handles the annotations for you
        /// Just create a blank print document, provide it to the print dialog, then pass on to the Print() method
        /// </summary>
        private void PrintImages()
        {
            using (var printDoc = new AnnotatePrintDocument())
            {
                using (var diag = new PrintDialog())
                {
                    diag.Document = printDoc;
                    if (diag.ShowDialog() == DialogResult.OK)
                    {
                        annotationViewer.Print(printDoc);
                    }
                }
            }
        }

        private void EnableDisableMenuAndToolbarItems()
        {
            bool fileLoaded = annotationViewer.Count > 0;
            saveAsToolStripMenuItem.Enabled = fileLoaded;
            printToolStripMenuItem.Enabled = fileLoaded;
            toolStripPrint.Enabled = fileLoaded;
            toolStripSave.Enabled = fileLoaded;
            toolStripAnnotations.Enabled = fileLoaded;
            toolStripPointer.Enabled = fileLoaded;
            toolStripSelection.Enabled = fileLoaded;
            toolStripZoomIn.Enabled = fileLoaded && annotationViewer.ImageControl.AutoZoom == AutoZoomMode.None;
            toolStripZoomOut.Enabled = fileLoaded && annotationViewer.ImageControl.AutoZoom == AutoZoomMode.None;

            bool annotationSelected = annotationViewer.Annotations.ActiveAnnotation != null;
            cutToolStripMenuItem.Enabled = annotationSelected;
            copyToolStripMenuItem.Enabled = annotationSelected;
            toolStripCut.Enabled = annotationSelected;
            toolStripCopy.Enabled = annotationSelected;

            bool canPaste = annotationViewer.Annotations.CanPaste();
            pasteToolStripMenuItem.Enabled = canPaste;
            toolStripPaste.Enabled = canPaste;

            bool canUndo = annotationViewer.Annotations.UndoManager.UndoCount > 0;
            bool canRedo = annotationViewer.Annotations.UndoManager.RedoCount > 0;
            undoToolStripMenuItem.Enabled = canUndo;
            redoToolStripMenuItem.Enabled = canRedo;
            toolStripUndo.Enabled = canUndo;
            toolStripRedo.Enabled = canRedo;
        }

        private void PerformUndo()
        {
            annotationViewer.Annotations.UndoManager.Undo();
            EnableDisableMenuAndToolbarItems();
        }

        private void PerformRedo()
        {
            annotationViewer.Annotations.UndoManager.Redo();
            EnableDisableMenuAndToolbarItems();
        }

        private void PerformCut()
        {
            annotationViewer.Annotations.Cut();
            EnableDisableMenuAndToolbarItems();
        }

        private void PerformCopy()
        {
            annotationViewer.Annotations.Copy();
            EnableDisableMenuAndToolbarItems();
        }

        private void PerformPaste()
        {
            annotationViewer.Annotations.Paste();
            EnableDisableMenuAndToolbarItems();
        }

        private AnnotationBrush GetAnnotationBrush(AnnotationUI annotation, string propertyName)
        {
            return GetAnnotationProperty<AnnotationBrush>(annotation, propertyName);
        }

        private AnnotationPen GetAnnotationPen(AnnotationUI annotation, string propertyName)
        {
            return GetAnnotationProperty<AnnotationPen>(annotation, propertyName);
        }

        private T GetAnnotationProperty<T>(AnnotationUI annotation, string propertyName) where T : class
        {
            Type at = annotation.GetType();
            PropertyInfo info = at.GetProperty(propertyName);
            if (info == null) return null;

            return info.GetValue(annotation, null) as T;
        }

        private Color GetColor(Color current)
        {
            using (var dlg = new ColorDialog())
            {
                dlg.Color = current;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    return dlg.Color;
                return Color.Empty;
            }
        }

        private void UpdateAnnotationDefault(AnnotationUI annotation)
        {
            if (string.IsNullOrEmpty(annotation.Data.Name))
                return;

            var annotationType = typeof(AnnotationType);
            if (Enum.IsDefined(annotationType, annotation.Data.Name))
            {
                var at = (AnnotationType)Enum.Parse(annotationType, annotation.Data.Name);
                _defaultAnnotations.UpdateAnnotation(at, annotation);
            }
        }

        private void SwitchAnnotationAuthorMode(bool authoring)
        {
            if (authoring)
            {
                annotationViewer.ImageControl.MouseTool = MouseToolType.None;
                annotationViewer.Annotations.InteractMode = AnnotateInteractMode.Author;
            }
            else
            {
                annotationViewer.Annotations.InteractMode = AnnotateInteractMode.None;

                // The first time we switch the MouseTool to Selection we have to add the Changed event handler.
                bool addEvent = annotationViewer.ImageControl.Selection == null;
                annotationViewer.ImageControl.MouseTool = MouseToolType.Selection;
                if (addEvent)
                {
                    annotationViewer.ImageControl.Selection.Changed += AnnotationViewer_SelectionRectangleChanged;
                    annotationViewer.ImageControl.Selection.ClickLock = false;
                }

                annotationViewer.ImageControl.Selection.SetDisplayBounds(RectangleF.Empty);
            }

            annotationViewer.ImageControl.Selection.Visible = !authoring;
            toolStripSelection.Checked = !authoring;
            toolStripPointer.Checked = authoring;
            toolStripAnnotations.Enabled = authoring;
        }

        private void SetZoomMode(AutoZoomMode mode)
        {
            annotationViewer.ImageControl.AutoZoom = mode;

            if (mode == AutoZoomMode.None)
            {
                annotationViewer.ImageControl.Zoom = 1.0;
                toolStripZoomIn.Enabled = true;
                toolStripZoomOut.Enabled = true;
            }
            else
            {
                toolStripZoomIn.Enabled = false;
                toolStripZoomOut.Enabled = false;
            }
        }
        #endregion Misc Methods

        #region File Menu

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImageFile();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageFile();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintImages();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseCurrentFile();
            Close();
        }

        #endregion

        #region Edit Menu

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformUndo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformRedo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformCut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformCopy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerformPaste();
        }

        #endregion

        #region Help Menu

        private void HelpAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new About("About Atalasoft DotImage Document Annotation Viewer Demo",
                "DotImage Document Annotation Viewer Demo");
            aboutBox.Description = "The Document Annotation Viewer Demo demonstrates how to use our DocumentAnnotationViewer control. \r\n\r\nThis demo should be used to gain a basic understanding of how the DotImage DocumentAnnotationViewer functions. \r\n\r\nThe demo allows you to open various supported image files, automatically loading any supported embedded annotations. It also allows the creation / editing of various annotation types and saving out the resulting file with annotaions being embedded for supported formats. Additionally, it shows the ease of use of the built in undo/redo manager, as well as cut, copy, and paste of annotations, and even full document printing with annotations.  Requires DotImage license. Optionally, requires PdfRasterizer license in order to open/read PDF files.";
            aboutBox.ShowDialog();
        }

        #endregion Help Menu

        #region Tool Strips

        private void ToolStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Open":
                    OpenImageFile();
                    break;
                case "Save":
                    SaveImageFile();
                    break;
                case "Print":
                    PrintImages();
                    break;
                case "Undo":
                    PerformUndo();
                    break;
                case "Redo":
                    PerformRedo();
                    break;
                case "Cut":
                    PerformCut();
                    break;
                case "Copy":
                    PerformCopy();
                    break;
                case "Paste":
                    PerformPaste();
                    break;
                case "Pointer":
                    if (!toolStripPointer.Checked)
                        SwitchAnnotationAuthorMode(true);
                    break;
                case "Selection Tool":
                    if (!toolStripSelection.Checked)
                        SwitchAnnotationAuthorMode(false);
                    break;
                case "Zoom In":
                    annotationViewer.ImageControl.Zoom += 0.1;
                    break;
                case "Zoom Out":
                    annotationViewer.ImageControl.Zoom -= 0.1;
                    break;
            }
        }

        private void ToolStripAnnotations_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var annotationController = annotationViewer.Annotations;
            annotationController.ClearSelection();

            switch (e.ClickedItem.Text)
            {
                case "Rectangle":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Rectangle));
                    break;
                case "Ellipse":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Ellipse));
                    break;
                case "Single Line":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Line));
                    break;
                case "Connected Lines":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Lines));
                    break;
                case "Freehand":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Freehand));
                    break;
                case "Polygon":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Polygon));
                    break;
                case "Highlighter":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.RectangleHighlighter));
                    break;
                case "Freehand Highlighter":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.FreehandHighlighter));
                    break;
                case "Embedded Image":
                    string embeddedFileName = GetFilename();
                    if (embeddedFileName != null)
                    {
                        var ann = _defaultAnnotations.GetAnnotation(AnnotationType.EmbeddedImage) as EmbeddedImageAnnotation;
                        ann.Image = new AnnotationImage(embeddedFileName);
                        annotationController.CreateAnnotation(ann);
                    }

                    break;
                case "Referenced Image":
                    string referencedFileName = GetFilename();
                    if (referencedFileName != null)
                    {
                        var rann = _defaultAnnotations.GetAnnotation(AnnotationType.ReferencedImage) as ReferencedImageAnnotation;
                        rann.FileName = referencedFileName;
                        annotationController.CreateAnnotation(rann);
                    }

                    break;
                case "Text":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Text));
                    break;
                case "Callout":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Callout));
                    break;
                case "Sticky Note":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.StickyNote), CreateAnnotationMode.SingleClickCenter);
                    break;
                case "Rubber Stamp":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.RubberStamp), CreateAnnotationMode.SingleClickCenter);
                    break;
                case "Redaction":
                    annotationController.CreateAnnotation(_defaultAnnotations.GetAnnotation(AnnotationType.Redaction));
                    break;
            }
        }

        /// <summary>
        /// Initializes the AnnotationToolstrip icons and loads them
        /// </summary>
        private void LoadAnnotationToolbarImages()
        {
            // Use the images provided within DotAnnotate.
            _annotationImages = new ImageList();
            _annotationImages.ImageSize = new Size(16, 16);
            _annotationImages.ColorDepth = ColorDepth.Depth32Bit;
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Callout, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Ellipse, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Freehand, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.FreehandHighlighter, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.RectangleHighlighter, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.EmbeddedImage, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Line, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Lines, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.StickyNote, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Polygon, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Rectangle, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Redact, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.ReferencedImage, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.RubberStamp, AnnotateIconSize.Size16));
            _annotationImages.Images.Add(AddIcon(AnnotateIcon.Text, AnnotateIconSize.Size16));

            toolStripAnnotations.ImageList = _annotationImages;
            toolStripCallout.ImageIndex = 0;
            toolStripEllipse.ImageIndex = 1;
            toolStripFreehand.ImageIndex = 2;
            toolStripFreehandHighlighter.ImageIndex = 3;
            toolStripHighlighter.ImageIndex = 4;
            toolStripImage.ImageIndex = 5;
            toolStripLine.ImageIndex = 6;
            toolStripLines.ImageIndex = 7;
            toolStripNote.ImageIndex = 8;
            toolStripPolygon.ImageIndex = 9;
            toolStripRectangle.ImageIndex = 10;
            toolStripRedaction.ImageIndex = 11;
            toolStripReferencedImage.ImageIndex = 12;
            toolStripRubberStamp.ImageIndex = 13;
            toolStripText.ImageIndex = 14;
        }

        private Image AddIcon(AnnotateIcon annotateIcon, AnnotateIconSize annotateIconSize)
        {
            var img = IconResource.ExtractAnnotationIcon(annotateIcon, annotateIconSize);
            if (img == null)
            {
                var assembly = Assembly.LoadFrom(@"Atalasoft.dotImage.dll");
                if (assembly != null)
                {
                    var stream = assembly.GetManifestResourceStream("Atalasoft.Imaging.Annotate.Icons._" + annotateIconSize.ToString().Substring(4) + "." + annotateIcon + ".png");
                    img = Image.FromStream(stream);
                }

                if (img == null)
                {
                    if (annotateIconSize.ToString() == "size16")
                        return new AtalaImage(16, 16, PixelFormat.Pixel24bppBgr, Color.White).ToBitmap();
                    if (annotateIconSize.ToString() == "size24")
                        return new AtalaImage(24, 24, PixelFormat.Pixel24bppBgr, Color.White).ToBitmap();
                    if (annotateIconSize.ToString() == "size32")
                        return new AtalaImage(32, 32, PixelFormat.Pixel24bppBgr, Color.White).ToBitmap();
                }
            }

            return img;
        }
        #endregion

        #region Status bar menu

        private void FitToHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetZoomMode(AutoZoomMode.FitToHeight);
        }

        private void FitToWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetZoomMode(AutoZoomMode.FitToWidth);
        }

        private void BestFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetZoomMode(AutoZoomMode.BestFitShrinkOnly);
        }

        private void NoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetZoomMode(AutoZoomMode.None);
        }

        #endregion

        #region Context Menu

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // Enable/disable menu items based on the annotation.
            AnnotationUI annotation = annotationViewer.Annotations.ActiveAnnotation;
            Type at = annotation.GetType();

            borderColorToolStripMenuItem.Enabled = at.GetProperty("Outline") != null;
            fillColorToolStripMenuItem.Enabled = at.GetProperty("Fill") != null && at.Name != "RubberStampAnnotation";
            textColorToolStripMenuItem.Enabled = at.GetProperty("FontBrush") != null;
            fontToolStripMenuItem.Enabled = at.GetProperty("Font") != null;
        }

        private void BorderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnotationPen pen = GetAnnotationPen(annotationViewer.Annotations.ActiveAnnotation, "Outline");
            if (pen == null) return;

            Color clr = GetColor(pen.Color);
            if (clr != Color.Empty)
            {
                if (pen.Brush != null && pen.Brush.FillType == FillType.Hatch)
                    pen.Brush.HatchForeColor = clr;
                else
                    pen.Color = clr;
            }

            UpdateAnnotationDefault(annotationViewer.Annotations.ActiveAnnotation);
        }

        private void FillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnotationBrush brush = GetAnnotationBrush(annotationViewer.Annotations.ActiveAnnotation, "Fill");
            if (brush == null) return;

            Color clr = GetColor(brush.Color);
            if (clr != Color.Empty) brush.Color = clr;
            UpdateAnnotationDefault(annotationViewer.Annotations.ActiveAnnotation);
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnotationUI annotation = annotationViewer.Annotations.ActiveAnnotation;
            Type at = annotation.GetType();
            PropertyInfo info = at.GetProperty("Font");
            if (info == null) return;

            AnnotationFont font = info.GetValue(annotation, null) as AnnotationFont;
            if (font == null) return;

            FontStyle fontStyle = FontStyle.Regular;
            if (font.Bold) fontStyle = FontStyle.Bold;
            if (font.Italic) fontStyle |= FontStyle.Italic;
            if (font.Strikeout) fontStyle |= FontStyle.Strikeout;
            if (font.Underline) fontStyle |= FontStyle.Underline;

            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = new Font(font.Name, font.Size, fontStyle);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    font = new AnnotationFont(dlg.Font.Name, dlg.Font.Size, dlg.Font.Bold, dlg.Font.Italic, dlg.Font.Underline, dlg.Font.Strikeout);
                    info.SetValue(annotation, font, null);
                }
            }

            UpdateAnnotationDefault(annotation);
        }

        private void TextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnotationBrush brush = GetAnnotationBrush(annotationViewer.Annotations.ActiveAnnotation, "FontBrush");
            if (brush == null) return;

            Color clr = GetColor(brush.Color);
            if (clr != Color.Empty)
            {
                if (brush.FillType == FillType.Hatch)
                    brush.HatchForeColor = clr;
                else
                    brush.Color = clr;
            }

            UpdateAnnotationDefault(annotationViewer.Annotations.ActiveAnnotation);
        }

        #endregion Context Menu
    }
}