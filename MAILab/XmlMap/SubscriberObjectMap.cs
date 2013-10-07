using System.Xml.Serialization;

namespace MAILab.XmlMap
{
    [XmlRootAttribute("DataBase", Namespace = "http://www.cpandl.com", IsNullable = false)]
    public class SubscriberObjectMap
    {
        [XmlArray("Subscribers")]
        public Subscriber[] Subscribers { get; set; }
    }   
}
