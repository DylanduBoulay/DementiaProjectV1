using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using GMap.NET;
using GMap.NET.WindowsForms;


namespace Assignment1_ICT365
{
    public partial class Form1 : Form
    {
        private EventsHandler MEH;                      //My Event Handler, abbreviated for the sake of simplicity.
        private string CurrentDateTime { get; set; }
        
        IList<GMapOverlay> markers = new List<GMapOverlay>();
        GMapOverlay routes = new GMapOverlay("routes");
        
        protected double Lat { get; set; }
        protected double Lng { get; set; }
        private bool InitTest = false;


        public Form1()
        {
            InitializeComponent();
            MEH = new EventsHandler();
            MEH.LoadXMLContents(gmap, markers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent_Btn.Visible = false;
            AddEvent_Panel.Visible = false;
            OptionsPanel.Visible = true;
            OptionsCancel.Visible = true;
            ShowEventTypes(EventTypes_ComboBox.Items);
            CurrentDateTime = RefrestDateTime();
        }

        private void OptionsCancel_Click(object sender, EventArgs e)
        {
            AddEvent_Btn.Visible = true;
            AddEvent_Panel.Visible = true;
            OptionsPanel.Visible = false;
            OptionsCancel.Visible = false;
            ClearEventText();
        }

        private void CreateEvent_Click(object sender, EventArgs e)
        {
            if (EventTypes_ComboBox.Text != null)
            {
                if ((EventTypes_ComboBox.Text == "Picture" || EventTypes_ComboBox.Text == "Video")) 
                {

                    if (!string.IsNullOrEmpty(MediaFilePath_TextBox.Text) || !string.IsNullOrWhiteSpace(MediaFilePath_TextBox.Text))
                    {
                        MEH.AddComplexEvent(gmap, EventName.Text, EventTypes_ComboBox.Text, EventTxt.Text, Lat, Lng, CurrentDateTime, MediaFilePath_TextBox.Text);
                        ClearEventText();
                        MessageBox.Show("Event Created.");
                    }
                    else
                        MessageBox.Show("Add a file path.");
                }

                else
                {
                    MEH.AddSimpleEvent(gmap, EventName.Text, EventTypes_ComboBox.Text, EventTxt.Text, Lat, Lng, CurrentDateTime);
                    ClearEventText();
                    MessageBox.Show("Event Created.");
                }
                    
            }          
        }


        private void ClearEventText()
        {
            EventName.Clear();
            EventTxt.Clear();
            MediaFilePath_TextBox.Clear();
            MediaFilePath_TextBox.Clear();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowEvents_Btn_Click(object sender, EventArgs e)
        {
            ShowNearbyEvents_Panel.Visible = false;
            HideNearbyEvents_Panel.Visible = true;


        }

        private void HideEvents_btn_Click(object sender, EventArgs e)
        {
            ShowNearbyEvents_Panel.Visible = true;
            HideNearbyEvents_Panel.Visible = false;
        }

        private void GoogleMaps_WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void HideNearbyEvents_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NeatbyEventsTxt_Click(object sender, EventArgs e)
        {

        }


        private string RefrestDateTime()
        {
            DateTime Date_Time = new DateTime();
            Date_Time = DateTime.Now;
            DateTime_Txt.Text = Date_Time.ToString("dd/MM/yyyy" + " " + "HH:mm");
            return DateTime_Txt.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EventTypes_Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ShowEventTypes(IList EventTypes_Combobox)
        {
            EventTypes_Combobox.Clear();

            string[] EventTypes = { "TextMessage", "Tweet", "Phonecall", "Video", "Picture"};

            for (int i = 0; i < 5; i++)
            {
                EventTypes_Combobox.Add(EventTypes[i]);
            }

            EventTypes_ComboBox.Text = EventTypes[0];
        }


        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void EventTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void gMap_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(-31.957388618032535, 115.87835540123542);
            gmap.ShowCenter = false;
        }





        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            InitChecker(sender, e);
            MouseClickLocation(sender, e);
            UpdateDisplayedLocation();
        }


        private void MouseClickLocation(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Lat = gmap.FromLocalToLatLng(e.X, e.Y).Lat;
                Lng = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
         }
        }

        private void EventTypes_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //video and picture filepath textbox disabled if combobox is switched to another option
            MediaFilePath_Label.Visible = false;
            MediaFilePath_TextBox.Visible = false;
            MediaFilePath_TextBox.Clear();


            if(EventTypes_ComboBox.Text == "Video" || EventTypes_ComboBox.Text == "Picture")
            {
                MediaFilePath_Label.Visible = true;
                MediaFilePath_TextBox.Visible = true;
            }

        }

        private void DateTime_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEvent_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            Lat_Textbox.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Lat_Textbox.ReadOnly = true;
        }

        private void UpdateDisplayedLocation()
        {
            Lat_Textbox.ReadOnly = true;
            Long_Textbox.ReadOnly = true;
            Lat_Textbox.Text = Lat.ToString();
            Long_Textbox.Text = Lng.ToString();
        }

        private void InitChecker(object sender, MouseEventArgs e)
        {
                if (InitTest == false)
                {
                    AddEvent_Panel.Visible = true;
                    ShowNearbyEvents_Panel.Visible = true;
                    InitTest = true;
                }            
        }



        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MEH.DisplayEvents(NearbyEvent_Listbox.Items,(int)item.Tag);
           // ShowNearestEvent();

            
            Console.WriteLine(String.Format("Marker {0} was clicked.", item.Tag));
        }


        private void FindNearestMarker()
        {

        }

        private void ShowNearestEvent()
        {

        }


        private void PictureFilePath_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

