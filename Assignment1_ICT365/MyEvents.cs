using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System.Xml.Linq;

namespace Assignment1_ICT365
{



    class MyEvents : EventsHandler
    {
        internal string EventName { get; set; }
        internal int EventID { get; set; }
        internal string EventType { get; set; }
        internal string EventTxt { get; set; }
        internal double Latitude { get; set; }
        internal double Longitude { get; set; }
        internal string DateTime { get; set; }



        public MyEvents(string name, string type, int ID, string Txt, double newLatitude, double newLongitude, string newDateTime)
        {
            EventName = name;
            EventID = ID;
            EventType = type;
            EventTxt = Txt;
            Latitude = newLatitude;
            Longitude = newLongitude;
            DateTime = newDateTime;
        }

        public MyEvents()
        {

        }


        public virtual void CreateMyEvent(GMapControl gmap)
        {
            AppendEvent();
            CreateMarker(gmap);
        }


        private void AppendEvent()
        {
            XDocument Event = XDocument.Load(@"lifelog-events.xml");
            XElement AddedEvent = Event.Root;


            AddedEvent.Add(
                new XElement("Event",
                new XElement("EventName", EventName),
                new XElement("EventID", EventID),
                new XElement("EventType", EventType,
                new XElement("Description", EventTxt),
                new XElement("Lat", Latitude),
                new XElement("Long", Longitude),
                new XElement("Datetimestamp", DateTime))));


            Event.Save(@"lifelog-events.xml");
        }


        public virtual void CreateMarker(GMapControl gmap)
        {
            GMapOverlay GO = new GMapOverlay();
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), GMarkerGoogleType.arrow);
            gmap.Overlays.Add(GO);
            GO.Markers.Add(marker);
            marker.ToolTipText = EventType + "\n\n" + EventName + "\n" + EventTxt + "\n" + DateTime;
            //markers.Insert(EventID, GO);
        }


        public override void DisplayEvents(IList List, int Tag)
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

