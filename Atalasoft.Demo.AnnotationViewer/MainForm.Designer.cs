// ------------------------------------------------------------------------------------
// <copyright file="MainForm.Designer.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

namespace Atalasoft.Demo.AnnotationViewer
{
    /// <summary>
    /// Main application form.
    /// </summary>
    public partial class MainForm
    {
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStrip toolStripAnnotations;
        private System.Windows.Forms.ToolStripButton toolStripRectangle;
        private System.Windows.Forms.ToolStripButton toolStripEllipse;
        private System.Windows.Forms.ToolStripButton toolStripLine;
        private System.Windows.Forms.ToolStripButton toolStripLines;
        private System.Windows.Forms.ToolStripButton toolStripFreehand;
        private System.Windows.Forms.ToolStripButton toolStripPolygon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripHighlighter;
        private System.Windows.Forms.ToolStripButton toolStripFreehandHighlighter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripImage;
        private System.Windows.Forms.ToolStripButton toolStripReferencedImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripText;
        private System.Windows.Forms.ToolStripButton toolStripCallout;
        private System.Windows.Forms.ToolStripButton toolStripNote;
        private System.Windows.Forms.ToolStripButton toolStripRedaction;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripRubberStamp;
        private System.Windows.Forms.ToolStripMenuItem classifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confidentialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem draftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topSecretToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitToHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripSelection;
        private System.Windows.Forms.ToolStripButton toolStripZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripPointer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFile;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripZoom;
        private System.Windows.Forms.ToolStripMenuItem bestFitToolStripZoom;
        private System.Windows.Forms.ToolStripMenuItem fitToWidthToolStripZoom;
        private System.Windows.Forms.ToolStripMenuItem fitToHeightToolStripZoom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem borderColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textColorToolStripMenuItem;
        private Atalasoft.Annotate.UI.DocumentAnnotationViewer annotationViewer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpAboutToolStripMenuItem;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.annotationViewer = new Atalasoft.Annotate.UI.DocumentAnnotationViewer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusPage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPointer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSelection = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.noneToolStripZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.bestFitToolStripZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWidthToolStripZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToHeightToolStripZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAnnotations = new System.Windows.Forms.ToolStrip();
            this.toolStripRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripLines = new System.Windows.Forms.ToolStripButton();
            this.toolStripFreehand = new System.Windows.Forms.ToolStripButton();
            this.toolStripPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripHighlighter = new System.Windows.Forms.ToolStripButton();
            this.toolStripFreehandHighlighter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripReferencedImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripText = new System.Windows.Forms.ToolStripButton();
            this.toolStripCallout = new System.Windows.Forms.ToolStripButton();
            this.toolStripNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripRubberStamp = new System.Windows.Forms.ToolStripDropDownButton();
            this.classifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confidentialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.draftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topSecretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripRedaction = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.toolStripAnnotations.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.annotationViewer);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(901, 583);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(901, 657);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripMain);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripAnnotations);
            // 
            // annotationViewer
            // 
            this.annotationViewer.AnnotationDataProvider = null;
            this.annotationViewer.AnnotationSaveOptionsHandler = null;
            this.annotationViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annotationViewer.ImageControl.AntialiasDisplay = Atalasoft.Imaging.WinControls.AntialiasDisplayMode.ScaleToGray;
            this.annotationViewer.ImageControl.BackColor = System.Drawing.SystemColors.Control;
            this.annotationViewer.ImageControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.annotationViewer.ImageControl.Magnifier.BackColor = System.Drawing.Color.White;
            this.annotationViewer.ImageControl.Magnifier.BorderColor = System.Drawing.Color.Black;
            this.annotationViewer.ImageControl.Magnifier.Size = new System.Drawing.Size(100, 100);
            this.annotationViewer.ImageControl.MouseWheelScrolling = true;
            this.annotationViewer.Location = new System.Drawing.Point(0, 0);
            this.annotationViewer.Name = "annotationViewer";
            this.annotationViewer.Separator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.annotationViewer.Size = new System.Drawing.Size(901, 561);
            this.annotationViewer.TabIndex = 2;
            this.annotationViewer.Text = "annotationViewer";
            this.annotationViewer.ThumbnailControl.BackColor = System.Drawing.SystemColors.Window;
            this.annotationViewer.ThumbnailControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.annotationViewer.ThumbnailControl.DragSelectionColor = System.Drawing.Color.Red;
            this.annotationViewer.ThumbnailControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annotationViewer.ThumbnailControl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.annotationViewer.ThumbnailControl.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.annotationViewer.ThumbnailControl.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
            this.annotationViewer.ThumbnailControl.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
            this.annotationViewer.ThumbnailControl.SelectionMode = Atalasoft.Imaging.WinControls.ThumbnailSelectionMode.SingleSelect;
            this.annotationViewer.ThumbnailControl.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
            this.annotationViewer.ThumbnailControl.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.annotationViewer.ThumbnailControl.SelectionRectangleLineColor = System.Drawing.Color.Black;
            this.annotationViewer.ThumbnailControl.ThumbnailOffset = new System.Drawing.Point(0, 0);
            this.annotationViewer.ThumbnailControl.ThumbnailSize = new System.Drawing.Size(100, 100);
            this.annotationViewer.UndoLevels = 100;
            this.annotationViewer.UndoListChanged += new System.EventHandler(this.AnnotationViewer_UndoListChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusFile,
            this.toolStripStatusPage,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(901, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusFile
            // 
            this.toolStripStatusFile.Name = "toolStripStatusFile";
            this.toolStripStatusFile.Size = new System.Drawing.Size(749, 17);
            this.toolStripStatusFile.Spring = true;
            this.toolStripStatusFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusPage
            // 
            this.toolStripStatusPage.Name = "toolStripStatusPage";
            this.toolStripStatusPage.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusPage.Text = "Page 0 of 0";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.bestFitToolStripMenuItem,
            this.fitToWidthToolStripMenuItem,
            this.fitToHeightToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 20);
            this.toolStripDropDownButton1.Text = "Zoom Mode";
            this.toolStripDropDownButton1.ToolTipText = "Zoom Mode";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.NoneToolStripMenuItem_Click);
            // 
            // bestFitToolStripMenuItem
            // 
            this.bestFitToolStripMenuItem.Name = "bestFitToolStripMenuItem";
            this.bestFitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.bestFitToolStripMenuItem.Text = "Best Fit";
            this.bestFitToolStripMenuItem.Click += new System.EventHandler(this.BestFitToolStripMenuItem_Click);
            // 
            // fitToWidthToolStripMenuItem
            // 
            this.fitToWidthToolStripMenuItem.Name = "fitToWidthToolStripMenuItem";
            this.fitToWidthToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fitToWidthToolStripMenuItem.Text = "Fit to Width";
            this.fitToWidthToolStripMenuItem.Click += new System.EventHandler(this.FitToWidthToolStripMenuItem_Click);
            // 
            // fitToHeightToolStripMenuItem
            // 
            this.fitToHeightToolStripMenuItem.Name = "fitToHeightToolStripMenuItem";
            this.fitToHeightToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fitToHeightToolStripMenuItem.Text = "Fit to Height";
            this.fitToHeightToolStripMenuItem.Click += new System.EventHandler(this.FitToHeightToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(136, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripPrint,
            this.toolStripSeparator3,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripSeparator4,
            this.toolStripCut,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripSeparator2,
            this.toolStripPointer,
            this.toolStripSelection,
            this.toolStripZoomOut,
            this.toolStripZoomIn,
            this.toolStripDropDownButton2});
            this.toolStripMain.Location = new System.Drawing.Point(3, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(389, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripMain_ItemClicked);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = Properties.Resources.Open;
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpen.Text = "Open";
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = Properties.Resources.Save;
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrint.Image = Properties.Resources.Print;
            this.toolStripPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripPrint.Text = "Print";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = Properties.Resources.Undo;
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripUndo.Text = "Undo";
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = Properties.Resources.Redo;
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripRedo.Text = "Redo";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = Properties.Resources.Cut;
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripCut.Text = "Cut";
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = Properties.Resources.Copy;
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripCopy.Text = "Copy";
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = Properties.Resources.Paste;
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripPaste.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPointer
            // 
            this.toolStripPointer.Checked = true;
            this.toolStripPointer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPointer.Image = Properties.Resources.Control_Interactive_Button;
            this.toolStripPointer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPointer.Name = "toolStripPointer";
            this.toolStripPointer.Size = new System.Drawing.Size(23, 22);
            this.toolStripPointer.Text = "Pointer";
            // 
            // toolStripSelection
            // 
            this.toolStripSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSelection.Image = Properties.Resources.RectangleSelection;
            this.toolStripSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSelection.Name = "toolStripSelection";
            this.toolStripSelection.Size = new System.Drawing.Size(23, 22);
            this.toolStripSelection.Text = "Selection Tool";
            // 
            // toolStripZoomOut
            // 
            this.toolStripZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomOut.Image = Properties.Resources.Zoom_Out;
            this.toolStripZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomOut.Name = "toolStripZoomOut";
            this.toolStripZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomOut.Text = "Zoom Out";
            // 
            // toolStripZoomIn
            // 
            this.toolStripZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripZoomIn.Image = Properties.Resources.Zoom_In;
            this.toolStripZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripZoomIn.Name = "toolStripZoomIn";
            this.toolStripZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolStripZoomIn.Text = "Zoom In";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripZoom,
            this.bestFitToolStripZoom,
            this.fitToWidthToolStripZoom,
            this.fitToHeightToolStripZoom});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(79, 22);
            this.toolStripDropDownButton2.Text = "Zoom Mode:";
            // 
            // noneToolStripZoom
            // 
            this.noneToolStripZoom.Name = "noneToolStripZoom";
            this.noneToolStripZoom.Size = new System.Drawing.Size(133, 22);
            this.noneToolStripZoom.Text = "None";
            this.noneToolStripZoom.Click += new System.EventHandler(this.NoneToolStripMenuItem_Click);
            // 
            // bestFitToolStripZoom
            // 
            this.bestFitToolStripZoom.Name = "bestFitToolStripZoom";
            this.bestFitToolStripZoom.Size = new System.Drawing.Size(133, 22);
            this.bestFitToolStripZoom.Text = "Best Fit";
            this.bestFitToolStripZoom.Click += new System.EventHandler(this.BestFitToolStripMenuItem_Click);
            // 
            // fitToWidthToolStripZoom
            // 
            this.fitToWidthToolStripZoom.Name = "fitToWidthToolStripZoom";
            this.fitToWidthToolStripZoom.Size = new System.Drawing.Size(133, 22);
            this.fitToWidthToolStripZoom.Text = "Fit to Width";
            this.fitToWidthToolStripZoom.Click += new System.EventHandler(this.FitToWidthToolStripMenuItem_Click);
            // 
            // fitToHeightToolStripZoom
            // 
            this.fitToHeightToolStripZoom.Name = "fitToHeightToolStripZoom";
            this.fitToHeightToolStripZoom.Size = new System.Drawing.Size(133, 22);
            this.fitToHeightToolStripZoom.Text = "Fit to Height";
            this.fitToHeightToolStripZoom.Click += new System.EventHandler(this.FitToHeightToolStripMenuItem_Click);
            // 
            // toolStripAnnotations
            // 
            this.toolStripAnnotations.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAnnotations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRectangle,
            this.toolStripEllipse,
            this.toolStripLine,
            this.toolStripLines,
            this.toolStripFreehand,
            this.toolStripPolygon,
            this.toolStripSeparator6,
            this.toolStripHighlighter,
            this.toolStripFreehandHighlighter,
            this.toolStripSeparator7,
            this.toolStripImage,
            this.toolStripReferencedImage,
            this.toolStripSeparator8,
            this.toolStripText,
            this.toolStripCallout,
            this.toolStripNote,
            this.toolStripRubberStamp,
            this.toolStripRedaction});
            this.toolStripAnnotations.Location = new System.Drawing.Point(3, 49);
            this.toolStripAnnotations.Name = "toolStripAnnotations";
            this.toolStripAnnotations.Size = new System.Drawing.Size(363, 25);
            this.toolStripAnnotations.TabIndex = 2;
            this.toolStripAnnotations.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStripAnnotations_ItemClicked);
            // 
            // toolStripRectangle
            // 
            this.toolStripRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRectangle.Name = "toolStripRectangle";
            this.toolStripRectangle.Size = new System.Drawing.Size(23, 22);
            this.toolStripRectangle.Text = "Rectangle";
            // 
            // toolStripEllipse
            // 
            this.toolStripEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEllipse.Name = "toolStripEllipse";
            this.toolStripEllipse.Size = new System.Drawing.Size(23, 22);
            this.toolStripEllipse.Text = "Ellipse";
            // 
            // toolStripLine
            // 
            this.toolStripLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLine.Name = "toolStripLine";
            this.toolStripLine.Size = new System.Drawing.Size(23, 22);
            this.toolStripLine.Text = "Single Line";
            // 
            // toolStripLines
            // 
            this.toolStripLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLines.Name = "toolStripLines";
            this.toolStripLines.Size = new System.Drawing.Size(23, 22);
            this.toolStripLines.Text = "Connected Lines";
            // 
            // toolStripFreehand
            // 
            this.toolStripFreehand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFreehand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFreehand.Name = "toolStripFreehand";
            this.toolStripFreehand.Size = new System.Drawing.Size(23, 22);
            this.toolStripFreehand.Text = "Freehand";
            // 
            // toolStripPolygon
            // 
            this.toolStripPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPolygon.Name = "toolStripPolygon";
            this.toolStripPolygon.Size = new System.Drawing.Size(23, 22);
            this.toolStripPolygon.Text = "Polygon";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripHighlighter
            // 
            this.toolStripHighlighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHighlighter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHighlighter.Name = "toolStripHighlighter";
            this.toolStripHighlighter.Size = new System.Drawing.Size(23, 22);
            this.toolStripHighlighter.Text = "Highlighter";
            // 
            // toolStripFreehandHighlighter
            // 
            this.toolStripFreehandHighlighter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFreehandHighlighter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFreehandHighlighter.Name = "toolStripFreehandHighlighter";
            this.toolStripFreehandHighlighter.Size = new System.Drawing.Size(23, 22);
            this.toolStripFreehandHighlighter.Text = "Freehand Highlighter";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripImage
            // 
            this.toolStripImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImage.Name = "toolStripImage";
            this.toolStripImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripImage.Text = "Embedded Image";
            // 
            // toolStripReferencedImage
            // 
            this.toolStripReferencedImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReferencedImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReferencedImage.Name = "toolStripReferencedImage";
            this.toolStripReferencedImage.Size = new System.Drawing.Size(23, 22);
            this.toolStripReferencedImage.Text = "Referenced Image";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripText
            // 
            this.toolStripText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripText.Name = "toolStripText";
            this.toolStripText.Size = new System.Drawing.Size(23, 22);
            this.toolStripText.Text = "Text";
            // 
            // toolStripCallout
            // 
            this.toolStripCallout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCallout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCallout.Name = "toolStripCallout";
            this.toolStripCallout.Size = new System.Drawing.Size(23, 22);
            this.toolStripCallout.Text = "Callout";
            // 
            // toolStripNote
            // 
            this.toolStripNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNote.Name = "toolStripNote";
            this.toolStripNote.Size = new System.Drawing.Size(23, 22);
            this.toolStripNote.Text = "Sticky Note";
            // 
            // toolStripRubberStamp
            // 
            this.toolStripRubberStamp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRubberStamp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classifiedToolStripMenuItem,
            this.confidentialToolStripMenuItem,
            this.draftToolStripMenuItem,
            this.importantToolStripMenuItem,
            this.topSecretToolStripMenuItem});
            this.toolStripRubberStamp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRubberStamp.Name = "toolStripRubberStamp";
            this.toolStripRubberStamp.Size = new System.Drawing.Size(13, 22);
            this.toolStripRubberStamp.Text = "Rubber Stamp";
            // 
            // classifiedToolStripMenuItem
            // 
            this.classifiedToolStripMenuItem.Name = "classifiedToolStripMenuItem";
            this.classifiedToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.classifiedToolStripMenuItem.Text = "CLASSIFIED";
            this.classifiedToolStripMenuItem.Click += new System.EventHandler(this.RubberStampTool_Click);
            // 
            // confidentialToolStripMenuItem
            // 
            this.confidentialToolStripMenuItem.Name = "confidentialToolStripMenuItem";
            this.confidentialToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.confidentialToolStripMenuItem.Text = "CONFIDENTIAL";
            this.confidentialToolStripMenuItem.Click += new System.EventHandler(this.RubberStampTool_Click);
            // 
            // draftToolStripMenuItem
            // 
            this.draftToolStripMenuItem.Name = "draftToolStripMenuItem";
            this.draftToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.draftToolStripMenuItem.Text = "DRAFT";
            this.draftToolStripMenuItem.Click += new System.EventHandler(this.RubberStampTool_Click);
            // 
            // importantToolStripMenuItem
            // 
            this.importantToolStripMenuItem.Name = "importantToolStripMenuItem";
            this.importantToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.importantToolStripMenuItem.Text = "IMPORTANT";
            this.importantToolStripMenuItem.Click += new System.EventHandler(this.RubberStampTool_Click);
            // 
            // topSecretToolStripMenuItem
            // 
            this.topSecretToolStripMenuItem.Name = "topSecretToolStripMenuItem";
            this.topSecretToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.topSecretToolStripMenuItem.Text = "TOP SECRET";
            this.topSecretToolStripMenuItem.Click += new System.EventHandler(this.RubberStampTool_Click);
            // 
            // toolStripRedaction
            // 
            this.toolStripRedaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedaction.Name = "toolStripRedaction";
            this.toolStripRedaction.Size = new System.Drawing.Size(23, 22);
            this.toolStripRedaction.Text = "Redaction";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borderColorToolStripMenuItem,
            this.fillColorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.textColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip_Opening);
            // 
            // borderColorToolStripMenuItem
            // 
            this.borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            this.borderColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.borderColorToolStripMenuItem.Text = "Border Color";
            this.borderColorToolStripMenuItem.Click += new System.EventHandler(this.BorderColorToolStripMenuItem_Click);
            // 
            // fillColorToolStripMenuItem
            // 
            this.fillColorToolStripMenuItem.Name = "fillColorToolStripMenuItem";
            this.fillColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fillColorToolStripMenuItem.Text = "Fill Color";
            this.fillColorToolStripMenuItem.Click += new System.EventHandler(this.FillColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.TextColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpAboutToolStripMenuItem
            // 
            this.helpAboutToolStripMenuItem.Name = "helpAboutToolStripMenuItem";
            this.helpAboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.helpAboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpAboutToolStripMenuItem.Text = "&About";
            this.helpAboutToolStripMenuItem.Click += new System.EventHandler(this.HelpAboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 657);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Atalasoft Document Annotation Viewer";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStripAnnotations.ResumeLayout(false);
            this.toolStripAnnotations.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}