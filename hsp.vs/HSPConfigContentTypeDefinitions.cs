using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;

namespace hsp.vs
{
    internal static class HSPConfigContentTypeDefinitions
    {
        [Export] [Name("hspconf")] [BaseDefinition("text")] internal static ContentTypeDefinition
            hidingContentTypeDefinition;

        [Export] [FileExtension(".hsp")] [ContentType("hspconf")] internal static
            FileExtensionToContentTypeDefinition hiddenFileExtensionDefinition;
    }
}