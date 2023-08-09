using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Xml;

namespace Assignment1_ICT365
{
    interface ILinqHandler
    {
        Dictionary<string,dynamic> XMLSorter();
    }

     class EventsHandler
    {
        protected int TOTAL_Events { get; set; }
        protected int MAX_EVENTS = 200;
        protected Dictionary<string, dynamic> MyEventsFromFile = new Dictionary<string, dynamic>();
        protected MyEvents[] MapEvents;
        protected LinqHandler XMLObject = new LinqHandler();


        public EventsHandler()
        {
            TOTAL_Events = 0;
            MapEvents = new MyEvents[MAX_EVENTS];
        }


        public void AddComplexEvent(GMapControl gmap, string name, string type, string Txt, double newLatitude, double newLongitude, string newDateTime, string FilePath)
        {
            ++TOTAL_Events;

            if (type == "Picture") 
            { 
                MapEvents[TOTAL_Events] = new PictureEvent(name, type, TOTAL_Events, Txt, newLatitude, newLongitude, newDateTime, FilePath);
                MapEvents[TOTAL_Events].CreateMyEvent(gmap);
            }
                

            else if(type == "Video")
            {
                MapEvents[TOTAL_Events] = new VideoEvent(name, type, TOTAL_Events, Txt, newLatitude, newLongitude, newDateTime, FilePath);
                MapEvents[TOTAL_Events].CreateMyEvent(gmap);
            }
       
        }


        public void AddSimpleEvent(GMapControl gmap, string name, string type, string Txt, double newLatitude, double newLongitude, string newDateTime)
        {
            ++TOTAL_Events;

            if (type == "Tweet")
                {
                    MapEvents[TOTAL_Events] = new Tweet(name, type, TOTAL_Events, Txt, newLatitude, newLongitude, newDateTime);
                }
                else if (type == "Phonecall")
                    MapEvents[TOTAL_Events] = new Phonecall(name, type, TOTAL_Events, Txt, newLatitude, newLongitude, newDateTime);
                else if (type == "TextMessage")
                    MapEvents[TOTAL_Events] = new TextMessage(name, type, TOTAL_Events, Txt, newLatitude, newLongitude, newDateTime);

                MapEvents[TOTAL_Events].CreateMyEvent(gmap);                    

        }



        public void LoadXMLContents(GMapControl gmap, IList<GMapOverlay> markers)
        {
            MyEventsFromFile = XMLObject.XMLSorter();


            foreach (KeyValuePair<string, dynamic> y in MyEventsFromFile)
            {


                foreach (var G in y.Value)
                {
                    

                    if (y.Key == "TextMessage")
                    {
                        G.CreateMarker(gmap);
                        MapEvents[G.EventID] = G;
                        System.Console.Out.WriteLine("Text message" + TOTAL_Events);
                    }

                    else if (y.Key == "Picture")
                    {
                        G.CreateMarker(gmap);
                        MapEvents[G.EventID] = G;
                        System.Console.Out.WriteLine("Picture" + TOTAL_Events);

                    }

                    else if (y.Key == "Video")
                    {
                        G.CreateMarker(gmap);
                        MapEvents[G.EventID] = G;
                        System.Console.Out.WriteLine("Video" + TOTAL_Events);

                    }

                    else if (y.Key == "Phonecall")
                    {
                        G.CreateMarker(gmap);
                        MapEvents[G.EventID] = G;
                        System.Console.Out.WriteLine("Phonecall" + TOTAL_Events);

                    }

                    else if (y.Key == "Tweet")
                    {
                        G.CreateMarker(gmap);
                        MapEvents[G.EventID] = G;
                        System.Console.Out.WriteLine("Tweet" + TOTAL_Events);

                    }

                    TOTAL_Events++;
                }
            }
        }



        public virtual void DisplayEvents(IList List, int Tag)
        {
            List.Clear();

            if (MapEvents[Tag] != null)
            {
                List.Add(this.MapEvents[Tag].EventName);
                List.Add(this.MapEvents[Tag].EventID);
                List.Add(this.MapEvents[Tag].EventType);
                List.Add(this.MapEvents[Tag].EventTxt);
                List.Add(this.MapEvents[Tag].Latitude);
                List.Add(this.MapEvents[Tag].Longitude);
                List.Add(this.MapEvents[Tag].DateTime);
            }
        }
        }
}

