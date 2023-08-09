using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace Assignment1_ICT365
{
    class LinqHandler : ILinqHandler
    {
        public string filename = "lifelog-events.xml";


        public void XMLReadTest()
        {
            try
            {
                XElement mystoredevents = XElement.Load(@filename);
                System.Console.Out.WriteLine(mystoredevents);
            }

            catch (FileNotFoundException E)
            {
                System.Console.Out.WriteLine("Failed to read file");
            }

        }


        public Dictionary<string, dynamic>  XMLSorter()
        {
            XDocument mystoredevents = XDocument.Load(@filename);
            Dictionary<string, dynamic> eventList = new Dictionary<string, dynamic>();
            string[] MyEventTypes = new string[] { "TextMessage", "Phonecall", "Tweet", "Video", "Picture" };


            for (int i = 0; i < MyEventTypes.Length; i++)
            {
                var Event = from x in mystoredevents.Descendants("Event")
                            where x.Descendants(MyEventTypes[i]).Any()
                            select x;

                foreach (XElement x in Event)
                {
                    XElementChecker(x, eventList);    
                }
            }

            return eventList; 
        }



        private void XElementChecker(XElement el, Dictionary<string, dynamic> eventList)
        {

            if (el.Descendants("Tweet").Any())

            {
                if (eventList.ContainsKey("Tweet"))

                {
                    eventList["Tweet"].Add(new Tweet(el));
                }

                else

                {
                    eventList.Add("Tweet", new List<dynamic> { new Tweet(el) });
                }
            }


            else if (el.Descendants("Picture").Any())
            {
                if (eventList.ContainsKey("Picture"))
                {
                    eventList["Picture"].Add(new PictureEvent(el));
                }
                else
                {
                    eventList.Add("Picture", new List<dynamic> { new PictureEvent(el) });
                }
            }


            else if (el.Descendants("Phonecall").Any())
            {
                if (eventList.ContainsKey("Phonecall"))
                {
                    eventList["Phonecall"].Add(new Phonecall(el));
                }
                else
                {
                    eventList.Add("Phonecall", new List<dynamic> { new Phonecall(el) });
                }
            }


            else if (el.Descendants("TextMessage").Any())

            {


                if (eventList.ContainsKey("TextMessage"))
                {
                    eventList["TextMessage"].Add(new TextMessage(el));
                }
                else
                {
                    eventList.Add("TextMessage", new List<dynamic> { new TextMessage(el) });
                }
            }


            else if (el.Descendants("Video").Any())
            {
                if (eventList.ContainsKey("Video"))
                {
                   eventList["Video"].Add(new VideoEvent(el));
                }

                else
                {
                   eventList.Add("Video", new List<dynamic> { new VideoEvent(el) });
                }
            }

        }

    }
}


