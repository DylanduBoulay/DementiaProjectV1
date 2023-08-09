namespace Assignment1_ICT365
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddEvent_Btn = new System.Windows.Forms.Button();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.MediaFilePath_Label = new System.Windows.Forms.Label();
            this.MediaFilePath_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Long_Textbox = new System.Windows.Forms.TextBox();
            this.Lat_Textbox = new System.Windows.Forms.TextBox();
            this.EventTypes_ComboBox = new System.Windows.Forms.ComboBox();
            this.DateTime_Label = new System.Windows.Forms.Label();
            this.DateTime_Txt = new System.Windows.Forms.TextBox();
            this.EventTxt = new System.Windows.Forms.TextBox();
            this.EventTxt_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventTypeLabel = new System.Windows.Forms.Label();
            this.CreateEvent = new System.Windows.Forms.Button();
            this.OptionsCancel = new System.Windows.Forms.Button();
            this.HideNearbyEvents_Panel = new System.Windows.Forms.Panel();
            this.NearbyEvent_Listbox = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.HideEvents_btn = new System.Windows.Forms.Button();
            this.AddEvent_Panel = new System.Windows.Forms.Panel();
            this.ShowNearbyEvents_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OptionsPanel.SuspendLayout();
            this.HideNearbyEvents_Panel.SuspendLayout();
            this.AddEvent_Panel.SuspendLayout();
            this.ShowNearbyEvents_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEvent_Btn
            // 
            this.AddEvent_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEvent_Btn.AutoSize = true;
            this.AddEvent_Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddEvent_Btn.Location = new System.Drawing.Point(86, 5);
            this.AddEvent_Btn.Name = "AddEvent_Btn";
            this.AddEvent_Btn.Size = new System.Drawing.Size(67, 23);
            this.AddEvent_Btn.TabIndex = 1;
            this.AddEvent_Btn.Text = "Add Event";
            this.AddEvent_Btn.UseVisualStyleBackColor = true;
            this.AddEvent_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsPanel.Controls.Add(this.MediaFilePath_Label);
            this.OptionsPanel.Controls.Add(this.MediaFilePath_TextBox);
            this.OptionsPanel.Controls.Add(this.label4);
            this.OptionsPanel.Controls.Add(this.Long_Textbox);
            this.OptionsPanel.Controls.Add(this.Lat_Textbox);
            this.OptionsPanel.Controls.Add(this.EventTypes_ComboBox);
            this.OptionsPanel.Controls.Add(this.DateTime_Label);
            this.OptionsPanel.Controls.Add(this.DateTime_Txt);
            this.OptionsPanel.Controls.Add(this.EventTxt);
            this.OptionsPanel.Controls.Add(this.EventTxt_Label);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.Name_Label);
            this.OptionsPanel.Controls.Add(this.EventName);
            this.OptionsPanel.Controls.Add(this.EventTypeLabel);
            this.OptionsPanel.Controls.Add(this.CreateEvent);
            this.OptionsPanel.Controls.Add(this.OptionsCancel);
            this.OptionsPanel.Location = new System.Drawing.Point(803, 9);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(230, 418);
            this.OptionsPanel.TabIndex = 2;
            this.OptionsPanel.Visible = false;
            // 
            // MediaFilePath_Label
            // 
            this.MediaFilePath_Label.AutoSize = true;
            this.MediaFilePath_Label.Location = new System.Drawing.Point(18, 275);
            this.MediaFilePath_Label.Name = "MediaFilePath_Label";
            this.MediaFilePath_Label.Size = new System.Drawing.Size(79, 13);
            this.MediaFilePath_Label.TabIndex = 18;
            this.MediaFilePath_Label.Text = "Media File path";
            this.MediaFilePath_Label.Visible = false;
            // 
            // MediaFilePath_TextBox
            // 
            this.MediaFilePath_TextBox.Location = new System.Drawing.Point(111, 272);
            this.MediaFilePath_TextBox.Name = "MediaFilePath_TextBox";
            this.MediaFilePath_TextBox.Size = new System.Drawing.Size(100, 20);
            this.MediaFilePath_TextBox.TabIndex = 17;
            this.MediaFilePath_TextBox.Visible = false;
            this.MediaFilePath_TextBox.TextChanged += new System.EventHandler(this.PictureFilePath_TextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Longitude";
            // 
            // Long_Textbox
            // 
            this.Long_Textbox.Location = new System.Drawing.Point(111, 180);
            this.Long_Textbox.Name = "Long_Textbox";
            this.Long_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Long_Textbox.TabIndex = 14;
            this.Long_Textbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Lat_Textbox
            // 
            this.Lat_Textbox.Location = new System.Drawing.Point(111, 154);
            this.Lat_Textbox.Name = "Lat_Textbox";
            this.Lat_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Lat_Textbox.TabIndex = 13;
            this.Lat_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // EventTypes_ComboBox
            // 
            this.EventTypes_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventTypes_ComboBox.FormattingEnabled = true;
            this.EventTypes_ComboBox.Location = new System.Drawing.Point(113, 18);
            this.EventTypes_ComboBox.Name = "EventTypes_ComboBox";
            this.EventTypes_ComboBox.Size = new System.Drawing.Size(100, 21);
            this.EventTypes_ComboBox.TabIndex = 6;
            this.EventTypes_ComboBox.SelectedIndexChanged += new System.EventHandler(this.EventTypes_ComboBox_SelectedIndexChanged);
            // 
            // DateTime_Label
            // 
            this.DateTime_Label.AutoSize = true;
            this.DateTime_Label.Location = new System.Drawing.Point(20, 218);
            this.DateTime_Label.Name = "DateTime_Label";
            this.DateTime_Label.Size = new System.Drawing.Size(77, 13);
            this.DateTime_Label.TabIndex = 11;
            this.DateTime_Label.Text = "Date and Time";
            // 
            // DateTime_Txt
            // 
            this.DateTime_Txt.Location = new System.Drawing.Point(111, 218);
            this.DateTime_Txt.Multiline = true;
            this.DateTime_Txt.Name = "DateTime_Txt";
            this.DateTime_Txt.Size = new System.Drawing.Size(100, 38);
            this.DateTime_Txt.TabIndex = 10;
            this.DateTime_Txt.TextChanged += new System.EventHandler(this.DateTime_Txt_TextChanged);
            // 
            // EventTxt
            // 
            this.EventTxt.Location = new System.Drawing.Point(111, 92);
            this.EventTxt.Multiline = true;
            this.EventTxt.Name = "EventTxt";
            this.EventTxt.Size = new System.Drawing.Size(100, 55);
            this.EventTxt.TabIndex = 9;
            this.EventTxt.TextChanged += new System.EventHandler(this.EventTxt_TextChanged);
            // 
            // EventTxt_Label
            // 
            this.EventTxt_Label.AutoSize = true;
            this.EventTxt_Label.Location = new System.Drawing.Point(20, 92);
            this.EventTxt_Label.Name = "EventTxt_Label";
            this.EventTxt_Label.Size = new System.Drawing.Size(60, 13);
            this.EventTxt_Label.TabIndex = 8;
            this.EventTxt_Label.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Latitude";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(14, 51);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(66, 13);
            this.Name_Label.TabIndex = 6;
            this.Name_Label.Text = "Event Name";
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(113, 51);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(98, 20);
            this.EventName.TabIndex = 5;
            this.EventName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EventTypeLabel
            // 
            this.EventTypeLabel.AutoSize = true;
            this.EventTypeLabel.Location = new System.Drawing.Point(18, 18);
            this.EventTypeLabel.Name = "EventTypeLabel";
            this.EventTypeLabel.Size = new System.Drawing.Size(62, 13);
            this.EventTypeLabel.TabIndex = 4;
            this.EventTypeLabel.Text = "Event Type";
            this.EventTypeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateEvent
            // 
            this.CreateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateEvent.Location = new System.Drawing.Point(5, 392);
            this.CreateEvent.Name = "CreateEvent";
            this.CreateEvent.Size = new System.Drawing.Size(86, 23);
            this.CreateEvent.TabIndex = 3;
            this.CreateEvent.Text = "Create Event";
            this.CreateEvent.UseVisualStyleBackColor = true;
            this.CreateEvent.Click += new System.EventHandler(this.CreateEvent_Click);
            // 
            // OptionsCancel
            // 
            this.OptionsCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OptionsCancel.Location = new System.Drawing.Point(136, 392);
            this.OptionsCancel.Name = "OptionsCancel";
            this.OptionsCancel.Size = new System.Drawing.Size(75, 23);
            this.OptionsCancel.TabIndex = 3;
            this.OptionsCancel.Text = "Cancel";
            this.OptionsCancel.UseVisualStyleBackColor = true;
            this.OptionsCancel.Click += new System.EventHandler(this.OptionsCancel_Click);
            // 
            // HideNearbyEvents_Panel
            // 
            this.HideNearbyEvents_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideNearbyEvents_Panel.Controls.Add(this.label12);
            this.HideNearbyEvents_Panel.Controls.Add(this.label11);
            this.HideNearbyEvents_Panel.Controls.Add(this.label10);
            this.HideNearbyEvents_Panel.Controls.Add(this.label9);
            this.HideNearbyEvents_Panel.Controls.Add(this.label8);
            this.HideNearbyEvents_Panel.Controls.Add(this.label7);
            this.HideNearbyEvents_Panel.Controls.Add(this.label6);
            this.HideNearbyEvents_Panel.Controls.Add(this.label3);
            this.HideNearbyEvents_Panel.Controls.Add(this.NearbyEvent_Listbox);
            this.HideNearbyEvents_Panel.Controls.Add(this.label2);
            this.HideNearbyEvents_Panel.Controls.Add(this.HideEvents_btn);
            this.HideNearbyEvents_Panel.Location = new System.Drawing.Point(1039, 9);
            this.HideNearbyEvents_Panel.Name = "HideNearbyEvents_Panel";
            this.HideNearbyEvents_Panel.Size = new System.Drawing.Size(208, 415);
            this.HideNearbyEvents_Panel.TabIndex = 3;
            this.HideNearbyEvents_Panel.Visible = false;
            this.HideNearbyEvents_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.HideNearbyEvents_Panel_Paint);
            // 
            // NearbyEvent_Listbox
            // 
            this.NearbyEvent_Listbox.LabelWrap = false;
            this.NearbyEvent_Listbox.Location = new System.Drawing.Point(60, 54);
            this.NearbyEvent_Listbox.Name = "NearbyEvent_Listbox";
            this.NearbyEvent_Listbox.Size = new System.Drawing.Size(127, 238);
            this.NearbyEvent_Listbox.TabIndex = 3;
            this.NearbyEvent_Listbox.UseCompatibleStateImageBehavior = false;
            this.NearbyEvent_Listbox.View = System.Windows.Forms.View.Tile;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, -141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clicked Event";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HideEvents_btn
            // 
            this.HideEvents_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideEvents_btn.Location = new System.Drawing.Point(120, 13);
            this.HideEvents_btn.Name = "HideEvents_btn";
            this.HideEvents_btn.Size = new System.Drawing.Size(75, 23);
            this.HideEvents_btn.TabIndex = 0;
            this.HideEvents_btn.Text = "Hide";
            this.HideEvents_btn.UseVisualStyleBackColor = true;
            this.HideEvents_btn.Click += new System.EventHandler(this.HideEvents_btn_Click);
            // 
            // AddEvent_Panel
            // 
            this.AddEvent_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEvent_Panel.Controls.Add(this.AddEvent_Btn);
            this.AddEvent_Panel.Location = new System.Drawing.Point(803, 16);
            this.AddEvent_Panel.Name = "AddEvent_Panel";
            this.AddEvent_Panel.Size = new System.Drawing.Size(230, 36);
            this.AddEvent_Panel.TabIndex = 5;
            this.AddEvent_Panel.Visible = false;
            this.AddEvent_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddEvent_Panel_Paint);
            // 
            // ShowNearbyEvents_Panel
            // 
            this.ShowNearbyEvents_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNearbyEvents_Panel.Controls.Add(this.label5);
            this.ShowNearbyEvents_Panel.Controls.Add(this.button1);
            this.ShowNearbyEvents_Panel.Location = new System.Drawing.Point(1044, 17);
            this.ShowNearbyEvents_Panel.Name = "ShowNearbyEvents_Panel";
            this.ShowNearbyEvents_Panel.Size = new System.Drawing.Size(200, 35);
            this.ShowNearbyEvents_Panel.TabIndex = 4;
            this.ShowNearbyEvents_Panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clicked Event";
            this.label3.Click += new System.EventHandler(this.NeatbyEventsTxt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(122, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowEvents_Btn_Click);
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(-1, -2);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 5;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1261, 909);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 13D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            this.gmap.Load += new System.EventHandler(this.gMap_Load);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            this.gmap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InitChecker);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Clicked Event";
            this.label5.Click += new System.EventHandler(this.NeatbyEventsTxt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Info";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lat.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Long.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Date/Time";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 905);
            this.Controls.Add(this.ShowNearbyEvents_Panel);
            this.Controls.Add(this.AddEvent_Panel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.HideNearbyEvents_Panel);
            this.Controls.Add(this.gmap);
            this.Name = "Form1";
            this.Text = "DementiaProg";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.HideNearbyEvents_Panel.ResumeLayout(false);
            this.HideNearbyEvents_Panel.PerformLayout();
            this.AddEvent_Panel.ResumeLayout(false);
            this.AddEvent_Panel.PerformLayout();
            this.ShowNearbyEvents_Panel.ResumeLayout(false);
            this.ShowNearbyEvents_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddEvent_Btn;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button OptionsCancel;
        private System.Windows.Forms.Button CreateEvent;
        private System.Windows.Forms.Label EventTypeLabel;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EventTxt_Label;
        private System.Windows.Forms.TextBox EventTxt;
        private System.Windows.Forms.TextBox DateTime_Txt;
        private System.Windows.Forms.Panel HideNearbyEvents_Panel;
        private System.Windows.Forms.Button HideEvents_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateTime_Label;
        private System.Windows.Forms.Panel AddEvent_Panel;
        private System.Windows.Forms.Panel ShowNearbyEvents_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView NearbyEvent_Listbox;
        private System.Windows.Forms.ComboBox EventTypes_ComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Long_Textbox;
        private System.Windows.Forms.TextBox Lat_Textbox;
        private System.Windows.Forms.TextBox MediaFilePath_TextBox;
        private System.Windows.Forms.Label MediaFilePath_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

