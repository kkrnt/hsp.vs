using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Operations;
using Microsoft.VisualStudio.Utilities;

namespace hsp.vs
{
    [Export(typeof (ICompletionSourceProvider))]
    [ContentType("hspconf")]
    [Name("HSP Completion")]
    [Order(Before = "default")]
    internal class HSPCompletion : ICompletionSourceProvider
    {
        [Import]
        internal ITextStructureNavigatorSelectorService NavigatorService { get; set; }

        public ICompletionSource TryCreateCompletionSource(ITextBuffer textBuffer)
        {
            return new HSPCompletionSource(this, textBuffer);
        }
    }
}