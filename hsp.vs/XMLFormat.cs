using System.Collections.Generic;
using System.Xml.Serialization;

namespace hsp.vs
{
    [XmlRoot("Index")]
    public class HSPXMLRoot
    {
        [XmlElement("command")]
        public List<HSPXMLElement> Element { get; set; }
    }

    public class HSPXMLElement
    {
        [XmlElement("Format")] public string Format;
        [XmlElement("Name")] public string Name;
        [XmlElement("Setting")] public string Setting;
        [XmlElement("Title")] public string Title;
    }
}