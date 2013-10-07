using System.Xml.Serialization;

namespace MAILab.XmlMap
{
    [XmlRootAttribute("DataBase", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class FilterObjectMap
    {
        [XmlArray("Filters")]
        public Filter[] Filters { get; set; }
    }
}
