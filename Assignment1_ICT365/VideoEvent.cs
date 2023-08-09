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
    class VideoEvent : MyEvents
    {
        /*This class is to act as the subclass, video
         * This will contain relevant information regarding the object of type video.
         */

        protected string VideoFilePath { get; set; }



        public VideoEvent(string name, string type, int ID, string Txt, double newLatitude, double newLongitude, string newDateTime,  string NewFilepath) : base(name, type, ID, Txt, newLatitude, newLongitude, newDateTime)
        {
            VideoFilePath = NewFilepath;
        }

        public VideoEvent(XElement el)
        {
            EventName = el.Element("EventName").Value;
            EventID = int.Parse(el.Element("EventID").Value);
            EventType = "Video";
            EventTxt = el.Element("Video").Element("Description").Value;
            Latitude = double.Parse(el.Element("Video").Element("Lat").Value);
            Longitude = double.Parse(el.Element("Video").Element("Long").Value);
            DateTime = el.Element("Video").Element("Datetimestamp").Value;
            VideoFilePath = el.Element("Video").Element("MediaFilePath").Value;
        }


        public VideoEvent(string name, string type, int ID, string Txt, double newLatitude, double newLongitude, string newDateTime) : base(name, type, ID, Txt, newLatitude, newLongitude, newDateTime)
        {


        }


        public override void CreateMarker(GMapControl gmap)
        {
            GMapOverlay GO = new GMapOverlay();
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), GMarkerGoogleType.black_small);
            gmap.Overlays.Add(GO);
            marker.Tag = EventID;
            GO.Markers.Add(marker);
            marker.ToolTipText = EventType + "\n\n" + EventName + "\n" + EventTxt + "\n" + DateTime;
        }



        public override void CreateMyEvent(GMapControl gmap)
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
                new XElement("Video",
                new XElement("Description", EventTxt),
                new XElement("Lat", Latitude), 
                new XElement("Long", Longitude),
                new XElement("Datetimestamp", DateTime),                               
                new XElement("MediaFilePath", VideoFilePath))));
            Event.Save(@"lifelog-events.xml");
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
