using ChallengeApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ChallengeApp {
    public partial class Form1 : Form {
        List<Vehicle> listVehicles;
        public static Form1 _form;
        public Vehicles _vehicles;
        string _extensionFile;
        public Form1() {
            _form = this;
            InitializeComponent();
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Challenge_C#.xml");
            var xmlserializer = new XmlSerializer(typeof(Vehicles));
            using (var reader = new StreamReader(path)) {
                var vehicles = (Vehicles)xmlserializer.Deserialize(reader);
                var source = new BindingSource(vehicles.Vehicle, null);
                listVehicles = vehicles.Vehicle.ToList();
                ChangeDataGridView(listVehicles);
            }
        }
        
        private void InitializeComponent() {
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btUpload = new System.Windows.Forms.Button();
            this.btDownloadJson = new System.Windows.Forms.Button();
            this.btDownloadXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(37, 98);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.Size = new System.Drawing.Size(543, 225);
            this.dgvVehicles.TabIndex = 2;
            this.dgvVehicles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(256, 22);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "Browser";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(175, 48);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(75, 23);
            this.btUpload.TabIndex = 5;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // btDownloadJson
            // 
            this.btDownloadJson.Location = new System.Drawing.Point(470, 329);
            this.btDownloadJson.Name = "btDownloadJson";
            this.btDownloadJson.Size = new System.Drawing.Size(110, 23);
            this.btDownloadJson.TabIndex = 6;
            this.btDownloadJson.Text = "Export data .json";
            this.btDownloadJson.UseVisualStyleBackColor = true;
            this.btDownloadJson.Click += new System.EventHandler(this.btDownloadJson_Click);
            // 
            // btDownloadXML
            // 
            this.btDownloadXML.Location = new System.Drawing.Point(363, 329);
            this.btDownloadXML.Name = "btDownloadXML";
            this.btDownloadXML.Size = new System.Drawing.Size(101, 23);
            this.btDownloadXML.TabIndex = 7;
            this.btDownloadXML.Text = "Export data .xml";
            this.btDownloadXML.UseVisualStyleBackColor = true;
            this.btDownloadXML.Click += new System.EventHandler(this.btDownloadXML_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(613, 427);
            this.Controls.Add(this.btDownloadXML);
            this.Controls.Add(this.btDownloadJson);
            this.Controls.Add(this.btUpload);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btRead_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "XML Files|*.xml|Json files (*.json)|*.json";
            
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                textBox1.Text = fileDialog.FileName;
                _extensionFile = Path.GetExtension(fileDialog.FileName);
            }
        }

        private void btUpload_Click(object sender, EventArgs e) {
            using (StreamReader sr = new StreamReader(textBox1.Text)) {
                string path = textBox1.Text;
                Vehicles vehicles = null;
                if (_extensionFile == ".xml") {
                    var xmlserializer = new XmlSerializer(typeof(Vehicles));
                    using (var reader = new StreamReader(path)) {
                        vehicles = (Vehicles)xmlserializer.Deserialize(reader);
                    }
                }
                else if(_extensionFile == ".json"){
                    string tmp = File.ReadAllText(path);
                    vehicles = JsonConvert.DeserializeObject<Vehicles>(tmp);
                }
                if (vehicles != null) {
                    ChangeDataGridView(vehicles.Vehicle);
                }
            }
        }

        private void btDownloadXML_Click(object sender, EventArgs e) {
            XmlSerializer ser = new XmlSerializer(typeof(Vehicles));
            using (FileStream fs = new FileStream(@"C:\\Challenge.xml", FileMode.Create)) {
                ser.Serialize(fs, _vehicles);
            }
        }
        
        private void btDownloadJson_Click(object sender, EventArgs e) {
            using (StreamWriter file = File.CreateText(@"C:\\Challenge.json")) {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, _vehicles);
            }
        }
        
        private void dgvVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Vehicle vehicle = new Vehicle();
            vehicle.Type = this.dgvVehicles.CurrentRow.Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(this.dgvVehicles.CurrentRow.Cells[1].Value.ToString())) {
                vehicle = listVehicles.Where(x => x.Id == int.Parse(this.dgvVehicles.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();
                EditForm eForm = new EditForm();
                EditForm._editform._tbVType.Text = vehicle.Type;
                EditForm._editform._tbVColor.Text = vehicle.Color;
                if (vehicle.Motor != null) {
                    EditForm._editform._tbMType.Text = vehicle.Motor.Type;
                    EditForm._editform._tbMPower.Text = vehicle.Motor.Power.ToString();
                }
                if(vehicle.Wheels != null) {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Size", typeof(string));
                    dt.Columns.Add("Pressure", typeof(string));
                    
                    foreach (var item in vehicle.Wheels.Wheel) {
                        dt.Rows.Add(new object[] { item.Size, item.Pressure });
                    }
                    EditForm._editform._dgvWheels.DataSource = dt;
                }
                EditForm._editform._vehicle = vehicle;
                eForm.Show();
            }
        }

        public void ChangeDataGridView(List<Vehicle> lstVehicles = null, Vehicle vehicle = null) {
            int lastVehicleId = 1;
            int lastMotorId = 1;
            int lastWheelId = 1;
            DataTable dataVehicles = new DataTable();
            dataVehicles.Columns.Add("Id", typeof(int));
            dataVehicles.Columns.Add("Vehicle", typeof(string));
            dataVehicles.Columns.Add("Motor", typeof(string));
            dataVehicles.Columns.Add("Power", typeof(string));
            // dataVehicles.Columns.Add("Size", typeof(string));
            _vehicles = new Vehicles();
            _vehicles.Vehicle = new List<Vehicle>();
            if (vehicle != null) {
                lstVehicles = listVehicles;
                foreach (var item in listVehicles) {
                    if (item.Id == vehicle.Id) {
                        item.Color = vehicle.Color;
                        item.Type = vehicle.Type;
                        item.Motor = vehicle.Motor;
                        item.Wheels = vehicle.Wheels;
                    }
                }
            }
            foreach (var s in lstVehicles) {
                s.Id = lastVehicleId++;
                if (s.Motor != null)
                    s.Motor.Id = lastMotorId++;
                foreach (var i in s.Wheels.Wheel) {
                    i.Id = lastWheelId++;
                }

                if (s.Motor == null)
                    dataVehicles.Rows.Add(new object[] { s.Id, s.Type, "", ""/*, s.Wheels.Wheel.FirstOrDefault().Size*/ });
                else
                    dataVehicles.Rows.Add(new object[] { s.Id, s.Type, s.Motor.Type, s.Motor.Power/*, s.Wheels.Wheel.FirstOrDefault().Size*/ });
                _vehicles.Vehicle.Add(s);
            }

            dgvVehicles.DataSource = dataVehicles;
        }
    }
}
