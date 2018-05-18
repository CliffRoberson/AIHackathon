using IBM.WatsonDeveloperCloud.Assistant.v1;
using IBM.WatsonDeveloperCloud.Assistant.v1.Model;
using IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model;
using Newtonsoft.Json;
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

            //for (int i = 0; i < d1.Count; i++)
            //{
            //    Console.WriteLine(d1.GetValue("ConsumerId", i));
            //}

            //var lu = new IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.NaturalLanguageUnderstandingService("337c22d1-14e0-45ea-9f64-ed54beb36238", "Pn3KRCbrWn1q", "2018-05-17");

            //Parameters parameters = new Parameters()
            //{
            //    Text = "It is so nice outside today",
            //    //ReturnAnalyzedText = true,
            //    Features = new Features()
            //    {
            //        Keywords = new KeywordsOptions()
            //        {
            //            Limit = 8,
            //            Sentiment = true,
            //            Emotion = true
            //        }
            //    }
            //};

            //{
            //    "url": "https://gateway.watsonplatform.net/assistant/api",
            //    "username": "61c4eac1-223d-48a8-9ebe-8d4d1678980e",
            //    "password": "RBt0EBx5Ghrb"
            //}

            //var conversation = new IBM.WatsonDeveloperCloud.Conversation.v1.ConversationService("61c4eac1-223d-48a8-9ebe-8d4d1678980e", "RBt0EBx5Ghrb", "2018-05-18");
            //conversation.
            var assistant = new AssistantService("61c4eac1-223d-48a8-9ebe-8d4d1678980e", "RBt0EBx5Ghrb", "2018-05-18");
            //

            //var result = lu.Analyze(parameters);

            var result = assistant.Message(
                "12288248-2b1a-4d9b-a528-e6c5c18a7a83",
                new MessageRequest()
                {
                    Input = new InputData()
                    {
                        Text = "Hello, how are you?"
                    }
                }
            );

            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));

            Console.WriteLine("Done loading datasets!");

            Console.ReadKey();
        }
    }
}
