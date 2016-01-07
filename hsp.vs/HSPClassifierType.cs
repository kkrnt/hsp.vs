using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace hsp.vs
{
    internal static class HSPClassifierClassificationDefinition
    {
        /// <summary>
        ///     Defines the "HSPClassifier" classification type.
        /// </summary>
        [Export(typeof (ClassificationTypeDefinition))] [Name("HSPClassifierValidFormat")] internal static
            ClassificationTypeDefinition HSPClassifierValidFormat = null;

        [Export(typeof (ClassificationTypeDefinition))] [Name("HSPClassifierNormalFormat")] internal static
            ClassificationTypeDefinition HSPClassifierNormalFormat = null;

        [Export(typeof (ClassificationTypeDefinition))] [Name("HSPClassifierCommentOutFormat")] internal static
            ClassificationTypeDefinition HSPClassifierCommentOutFormat = null;

        [Export(typeof (ClassificationTypeDefinition))] [Name("HSPClassifierKeywordFormat")] internal static
            ClassificationTypeDefinition HSPClassifierKeywordFormat = null;
    }
}