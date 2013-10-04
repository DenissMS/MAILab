using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MAILab
{
    class Filters
    {
        public int RetirementAge = 67;
        public List<string> Names;
        public Filters()
        {
            Names = new List<string>();
            var doc = XDocument.Load("Requests.xml");
            foreach (var req in doc.Descendants("Request"))
            {
                var xAttribute = req.Attribute("Name");
                if (xAttribute != null) Names.Add(xAttribute.Value);
            }
        }
        public List<Subscriber> FilterResults(List<Subscriber> data, FilterType type,)
        {
            var list= new List<Subscriber>();
            switch (type)
            {
                    case FilterType.KickSubscriber:
                    foreach (var subscriber in data)
                    {
                        var now = DateTime.Now;
                        var span = now.AddYears(67) - now;
                        if ((DateTime.Parse(subscriber.DateOfBirth) + span)>now)
                        {
                            list.Add(subscriber);
                        }
                    }
                        break;
            }
        }
    }

    enum FilterType
    {
        KickSubscriber
    }
}
