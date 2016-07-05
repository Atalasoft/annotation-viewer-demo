// ------------------------------------------------------------------------------------
// <copyright file="AnnotationDefaults.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using Atalasoft.Annotate;
using Atalasoft.Annotate.UI;

namespace Atalasoft.Demo.AnnotationViewer
{
    /// <summary>
    /// Class defines default properties of annotations.
    /// </summary>
    public class AnnotationDefaults
    {
        private readonly Hashtable _table;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationDefaults"/> class.
        /// </summary>
        public AnnotationDefaults()
        {
            _table = new Hashtable
            {
                { AnnotationType.Ellipse, new EllipseAnnotation(new AnnotationBrush(Color.Red), new AnnotationPen(Color.Red)) },
                { AnnotationType.EmbeddedImage, new EmbeddedImageAnnotation() },
                { AnnotationType.Freehand, new FreehandAnnotation(new AnnotationPen(Color.Blue, 4)) },
                { AnnotationType.Lines, new LinesAnnotation() },
                { AnnotationType.Polygon, new PolygonAnnotation(new AnnotationPen(Color.Black), new AnnotationBrush(Color.Green)) },
                { AnnotationType.Rectangle, new RectangleAnnotation(new AnnotationBrush(Color.Orange), new AnnotationPen(Color.Silver)) },
                { AnnotationType.ReferencedImage, new ReferencedImageAnnotation() },
                { AnnotationType.Text, new TextAnnotation(string.Empty, new AnnotationFont("Arial", 12), new AnnotationBrush(Color.Black), new AnnotationBrush(Color.Gainsboro), new AnnotationPen(Color.Black)) },
                { AnnotationType.Redaction, new RectangleAnnotation(new AnnotationBrush(Color.Black), null) }
            };

            // Callout
            var leader = new AnnotationPen(Color.Black, 2);
            leader.EndCap = new AnnotationLineCap(AnnotationLineCapStyle.Arrow, new SizeF(15, 15));
            _table.Add(AnnotationType.Callout, new CalloutAnnotation(string.Empty, new AnnotationFont("Times New Roman", 12), new AnnotationBrush(Color.Black), 4, new AnnotationBrush(Color.White), new AnnotationPen(Color.Black, 2), leader, 10));
            
            // Line
            var textOutline = new AnnotationPen(Color.Black);
            textOutline.EndCap = new AnnotationLineCap(AnnotationLineCapStyle.FilledArrow, new SizeF(15, 15));
            _table.Add(AnnotationType.Line, new LineAnnotation(textOutline));
            
            // Rubberstamp
            var stamp = new RubberStampAnnotation();
            stamp.Data.Size = new SizeF(400, 110);
            stamp.Data.CanMirror = false;
            stamp.Text = "DRAFT";
            _table.Add(AnnotationType.RubberStamp, stamp);

            // Sticky Note
            var sticky = new TextAnnotation(string.Empty, new AnnotationFont("Arial", 12), new AnnotationBrush(Color.Black), new AnnotationBrush(SystemColors.Info), new AnnotationPen(Color.Black, 1));
            sticky.Data.Size = new SizeF(200, 120);
            sticky.Shadow = new AnnotationBrush(Color.FromArgb(120, Color.Silver));
            sticky.ShadowOffset = new PointF(5, 5);
            _table.Add(AnnotationType.StickyNote, sticky);
            
            // Rectangle Highlighter
            var rc = new RectangleAnnotation(new AnnotationBrush(Color.Yellow), null);
            rc.Translucent = true;
            _table.Add(AnnotationType.RectangleHighlighter, rc);

            // Freehand Highlighter
            var fh = new FreehandAnnotation(new AnnotationPen(Color.Yellow, 20));
            fh.Translucent = true;
            fh.LineType = FreehandLineType.Curves;
            _table.Add(AnnotationType.FreehandHighlighter, fh);
        }

        /// <summary>
        /// Retrieves default annotation for specified annotation type.
        /// </summary>
        /// <param name="type">Annotation type.</param>
        /// <returns><see cref="AnnotationUI"/> instance for specified annotation type.</returns>
        public AnnotationUI GetAnnotation(AnnotationType type)
        {
            var ann = ((AnnotationUI)_table[type]).Clone();
            ann.Data.Name = type.ToString();
            return ann;
        }

        /// <summary>
        /// Updates default annotation for specified annotation type.
        /// </summary>
        /// <param name="type">Annotation type to update.</param>
        /// <param name="annotation"><see cref="AnnotationUI"/> instance for specified annotation type.</param>
        public void UpdateAnnotation(AnnotationType type, AnnotationUI annotation)
        {
            var newAnn = (AnnotationUI)_table[type];

            var at = newAnn.GetType();
            CopyProperty("Fill", at, annotation, newAnn);
            CopyProperty("Outline", at, annotation, newAnn);
            CopyProperty("Font", at, annotation, newAnn);
            CopyProperty("FontBrush", at, annotation, newAnn);

            if (type != AnnotationType.RubberStamp && type != AnnotationType.StickyNote)
                newAnn.Size = SizeF.Empty;

            _table[type] = newAnn;
        }

        private void CopyProperty(string propertyName, Type type, AnnotationUI annotation, AnnotationUI newAnnotation)
        {
            var info = type.GetProperty(propertyName);
            if (info == null) return;

            var val = info.GetValue(annotation, null);
            if (val == null) return;

            var objType = val.GetType();
            var cloneMethod = objType.GetMethod("Clone");

            info.SetValue(newAnnotation, cloneMethod.Invoke(val, null), null);
        }
    }
}
