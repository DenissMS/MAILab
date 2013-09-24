using System.Collections.Generic;
using System.Xml.Linq;

namespace ZPA_Lab_1
{
    class Requests
    {
        public List<string> Names;
        public Requests()
        {
            Names = new List<string>();
            var doc = XDocument.Load("Requests.xml");
            foreach (var req in doc.Descendants("Request"))
            {
                var xAttribute = req.Attribute("Name");
                if (xAttribute != null) Names.Add(xAttribute.Value);
            }
        }
    }
}
