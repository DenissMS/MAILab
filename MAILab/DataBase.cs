using System.Xml.Serialization;

namespace MAILab
{
    [XmlRootAttribute("DataBase", Namespace = "http://www.cpandl.com",
   IsNullable = false)]
    public class DataBase
    {
        [XmlArrayAttribute("Subscribers")]
        public Subscriber[] Subscribers { get; set; }
    }       
}
