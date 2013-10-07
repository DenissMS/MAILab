using System.Xml.Serialization;

namespace MAILab.XmlMap
{
    public class Filter
    {
        [XmlAttribute] public string ID;

        [XmlAttribute] public string Name;
        [XmlElement("Criteria")]
        public Criteria[] Criteria;
    }
}
