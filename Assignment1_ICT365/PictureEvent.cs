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
using System.Drawing;
using System.IO;

namespace Assignment1_ICT365
{
    class PictureEvent : MyEvents
    {

        protected string PictureFilePath { get; set; }


        public PictureEvent(string name, string type, int ID, string Txt, double newLatitude, double newLongitude, string newDateTime, string NewPictureFilePath) : base(name, type, ID, Txt, newLatitude, newLongitude, newDateTime)
        {
            PictureFilePath = NewPictureFilePath;
        }


        public PictureEvent(string name, string type, int ID, string Txt, double newLatitude, double newLongitude, string newDateTime) : base(name, type, ID, Txt, newLatitude, newLongitude, newDateTime)
        {


        }


        public PictureEvent(XElement el)
        {
            EventName = el.Element("EventName").Value;
            EventID = int.Parse(el.Element("EventID").Value);
            EventType = "Picture";
            EventTxt = el.Element("Picture").Element("Description").Value;
            Latitude = double.Parse(el.Element("Picture").Element("Lat").Value);
            Longitude = double.Parse(el.Element("Picture").Element("Long").Value);
            DateTime = el.Element("Picture").Element("Datetimestamp").Value;
            PictureFilePath = el.Element("Picture").Element("MediaFilePath").Value;
        }


        public override void CreateMarker(GMapControl gmap)
        {
                GMapOverlay GO = new GMapOverlay();
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(Latitude, Longitude), new Bitmap(ResizeImage()));
                gmap.Overlays.Add(GO);
                marker.Tag = EventID;
                GO.Markers.Add(marker);
                marker.ToolTipText = EventType + "\n\n" + EventName + "\n" + EventTxt + "\n" + DateTime;
                marker.ToolTip.TextPadding = new Size(16, 16);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private Bitmap ResizeImage()
        {
            Bitmap bmp = (Bitmap)Bitmap.FromFile(PictureFilePath);
            Bitmap result = new Bitmap(40, 40);
        
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, 40, 40);
            }
            return result;
        }

        public override void CreateMyEvent(GMapControl gmap)
        {
                CreateMarker(gmap);
                AppendEvent();             
        }

        private void AppendEvent()
        {
            XDocument Event = XDocument.Load(@"lifelog-events.xml");
            XElement AddedEvent = Event.Root;


            AddedEvent.Add(
                new XElement("Event",
                new XElement("EventName", EventName),
                new XElement("EventID", EventID),
                new XElement("Picture",
                new XElement("Description", EventTxt),
                new XElement("Lat", Latitude), 
                new XElement("Long", Longitude),
                new XElement("Datetimestamp", DateTime),
                new XElement("MediaFilePath", PictureFilePath))));
                
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
