using System;
using System.Collections.Generic;

namespace AITest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading datasets...");

            // dataservices_ubermedia_raw.consumer_id	dataservices_ubermedia_raw.visit_date	dataservices_ubermedia_raw.visit_time	dataservices_ubermedia_raw.visit_day_of_week	dataservices_ubermedia_raw.visit_timezone	dataservices_ubermedia_raw.visit_timestamp	dataservices_ubermedia_raw.polygon_name_new	dataservices_ubermedia_raw.polygon_category				
            var d1Headers = new Dictionary<string, int>();
            d1Headers.Add("ConsumerId", 0);
            d1Headers.Add("VisitDate", 1);
            d1Headers.Add("VisitTime", 2);
            d1Headers.Add("VisitDayOfWeek", 3);
            d1Headers.Add("VisitTimeZone", 4);
            d1Headers.Add("VisitTimestamp", 5);
            d1Headers.Add("PolygonCategory", 6);
            var d1 = new Dataset(@"C:\Users\shane.goggans\Desktop\Datasets\dataservices_ubermedia_raw.csv", d1Headers);

            for (int i = 0; i < d1.Count; i++)
            {
                Console.WriteLine(d1.GetValue("ConsumerId", i));
            }

            Console.WriteLine("Done loading datasets!");
        }
    }
}
