// ------------------------------------------------------------------------------------
// <copyright file="AnnotationType.cs" company="Atalasoft">
//     (c) 2000-2015 Atalasoft, a Kofax Company. All rights reserved. Use is subject to license terms.
// </copyright>
// ------------------------------------------------------------------------------------

namespace Atalasoft.Demo.AnnotationViewer
{
    /// <summary>
    /// Defines type of annotation.
    /// </summary>
    public enum AnnotationType
    {
        /// <summary>
        /// Callout annotation.
        /// </summary>
        Callout,

        /// <summary>
        /// Line annotation.
        /// </summary>
        Line,
        
        /// <summary>
        /// Lines annotation.
        /// </summary>
        Lines,

        /// <summary>
        /// Ellipse annotation.
        /// </summary>
        Ellipse,

        /// <summary>
        /// Rectangle annotation.
        /// </summary>
        Rectangle,

        /// <summary>
        /// Freehand annotation.
        /// </summary>
        Freehand,

        /// <summary>
        /// Rectangular highlighter annotation.
        /// </summary>
        RectangleHighlighter,

        /// <summary>
        /// Freehand highlighter annotation.
        /// </summary>
        FreehandHighlighter,
        
        /// <summary>
        /// Embedded image annotation.
        /// </summary>
        EmbeddedImage,

        /// <summary>
        /// Referenced image annotation.
        /// </summary>
        ReferencedImage,

        /// <summary>
        /// Polygon annotation.
        /// </summary>
        Polygon,

        /// <summary>
        /// Text annotation.
        /// </summary>
        Text,

        /// <summary>
        /// Sticky note annotation.
        /// </summary>
        StickyNote,

        /// <summary>
        /// Redaction annotation.
        /// </summary>
        Redaction,

        /// <summary>
        /// Rubber stamp annotation.
        /// </summary>
        RubberStamp
    }
}