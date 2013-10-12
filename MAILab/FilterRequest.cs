using System;
using System.Collections.Generic;
using MAILab.XmlMap;

namespace MAILab
{
    class FilterRequest
    {
        public const int RetirementAge = 67;
        public List<Subscriber> Subscribers;
 
        public FilterRequest(Subscriber[] data, Criteria[] criterias)
        {
            Subscribers = GetResult(data, criterias);
        }

        public static List<Subscriber> GetResult(Subscriber[] data, Criteria[] criterias)
        {
            var list = new List<Subscriber>();
            //FieldInfo fi = typeof(YourClass).GetField("field_name_here");
            //object fieldValue = fi.GetValue(yourClassInstance);
                    foreach (var subscriber in data)
                    {
                        var weed = false;
                        foreach (var criteria in criterias)
                        {
                            switch (criteria.Type)
                            {

                                case CriteriaType.Boolean:
                                    if ((bool) criteria.Value &&
                                        (bool) typeof (Subscriber).GetField(criteria.ID).GetValue(subscriber))
                                    {
                                        weed = !criteria.Exclusion;
                                    }

                                    continue;
                                case CriteriaType.Enumeration:
                                    continue;
                                case CriteriaType.Float:
                                case CriteriaType.Integer:
                                    var num = Convert.ToInt32(criteria.Value);
                                    if ((int)typeof(Subscriber).GetField(criteria.ID).GetValue(subscriber) >= num && num != 0)
                                    {
                                        weed = !criteria.Exclusion;
                                    }
                                    continue;
                            }
                        }

                        if (weed) list.Add(subscriber);
                    }
            return list;
        }
    }  
}
