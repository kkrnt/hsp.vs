using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace hsp.vs
{

    #region Format definition

    /// <summary>
    ///     Defines an editor format for the HSPClassifier type that has a purple background
    ///     and is underlined.
    /// </summary>
    [Export(typeof (EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "HSPClassifierValidFormat")]
    [Name("HSPClassifierValidFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class HSPClassifierValidFormat : ClassificationFormatDefinition
    {
        /// <summary>
        ///     Defines the visual format for the "HSPClassifier" classification type
        /// </summary>
        public HSPClassifierValidFormat()
        {
            DisplayName = "HSPClassifierValidFormat"; //human readable version of the name
            ForegroundColor = Colors.Blue;
        }
    }


    [Export(typeof (EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "HSPClassifierNormalFormat")]
    [Name("HSPClassifierNormalFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class HSPClassifierNormalFormat : ClassificationFormatDefinition
    {
        /// <summary>
        ///     Defines the visual format for the "HSPClassifier" classification type
        /// </summary>
        public HSPClassifierNormalFormat()
        {
            DisplayName = "HSPClassifierNormalFormat"; //human readable version of the name
            ForegroundColor = Colors.Black;
        }
    }

    [Export(typeof (EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "HSPClassifierCommentOutFormat")]
    [Name("HSPClassifierCommentOutFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class HSPClassifierCommentOutFormat : ClassificationFormatDefinition
    {
        /// <summary>
        ///     Defines the visual format for the "HSPClassifier" classification type
        /// </summary>
        public HSPClassifierCommentOutFormat()
        {
            DisplayName = "HSPClassifierCommentOutFormat"; //human readable version of the name
            ForegroundColor = Colors.Gray;
        }
    }

    [Export(typeof (EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "HSPClassifierKeywordFormat")]
    [Name("HSPClassifierKeywordFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    internal sealed class HSPClassifierKeywordFormat : ClassificationFormatDefinition
    {
        /// <summary>
        ///     Defines the visual format for the "HSPClassifier" classification type
        /// </summary>
        public HSPClassifierKeywordFormat()
        {
            DisplayName = "HSPClassifierKeywordFormat"; //human readable version of the name
            ForegroundColor = Colors.DarkGreen;
        }
    }

    #endregion //Format definition
}