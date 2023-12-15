using ChallengeApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ChallengeApp {
    public partial class EditForm : Form {
        public static EditForm _editform;
        public TextBox _tbVType;
        public TextBox _tbVColor;
        public TextBox _tbMType;
        public TextBox _tbMPower;
        public DataGridView _dgvWheels;
        public Vehicle _vehicle;
        public EditForm() {
            InitializeComponent();
            _editform = this;
            _tbVType = tbVehicleType;
            _tbVColor = tbVehicleColor;
            _tbMType = tbMotorType;
            _tbMPower = tbMotorPower;
            _dgvWheels = dgvWheels;
            _vehicle = new Vehicle();
        }

        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvWheels = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbVehicleType = new System.Windows.Forms.TextBox();
            this.tbMotorType = new System.Windows.Forms.TextBox();
            this.tbMotorPower = new System.Windows.Forms.TextBox();
            this.tbVehicleColor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWheels)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Power:";
            // 
            // dgvWheels
            // 
            this.dgvWheels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWheels.Location = new System.Drawing.Point(11, 232);
            this.dgvWheels.Name = "dgvWheels";
            this.dgvWheels.Size = new System.Drawing.Size(243, 147);
            this.dgvWheels.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Wheels:";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(179, 400);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "OK";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(98, 400);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbVehicleType
            // 
            this.tbVehicleType.Location = new System.Drawing.Point(52, 32);
            this.tbVehicleType.Name = "tbVehicleType";
            this.tbVehicleType.Size = new System.Drawing.Size(202, 20);
            this.tbVehicleType.TabIndex = 9;
            // 
            // tbMotorType
            // 
            this.tbMotorType.Location = new System.Drawing.Point(51, 134);
            this.tbMotorType.Name = "tbMotorType";
            this.tbMotorType.Size = new System.Drawing.Size(202, 20);
            this.tbMotorType.TabIndex = 11;
            // 
            // tbMotorPower
            // 
            this.tbMotorPower.Location = new System.Drawing.Point(51, 160);
            this.tbMotorPower.Name = "tbMotorPower";
            this.tbMotorPower.Size = new System.Drawing.Size(84, 20);
            this.tbMotorPower.TabIndex = 12;
            // 
            // tbVehicleColor
            // 
            this.tbVehicleColor.Location = new System.Drawing.Point(51, 58);
            this.tbVehicleColor.Name = "tbVehicleColor";
            this.tbVehicleColor.Size = new System.Drawing.Size(84, 20);
            this.tbVehicleColor.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color:";
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(141, 58);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(65, 22);
            this.btColor.TabIndex = 15;
            this.btColor.Text = "Search";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.btColor_Click);
            // 
            // EditForm
            // 
            this.ClientSize = new System.Drawing.Size(276, 440);
            this.Controls.Add(this.btColor);
            this.Controls.Add(this.tbVehicleColor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMotorPower);
            this.Controls.Add(this.tbMotorType);
            this.Controls.Add(this.tbVehicleType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvWheels);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWheels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btColor_Click(object sender, EventArgs e) {
            if(colorDialog.ShowDialog() == DialogResult.OK) {
                tbVehicleColor.Text = colorDialog.Color.Name;
            }
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e) {
            _vehicle.Type = _tbVType.Text;
            _vehicle.Color = tbVehicleColor.Text;
            if (_vehicle.Motor == null)
                _vehicle.Motor = new Motor();
            _vehicle.Motor.Type = _tbMType.Text;
            if(!string.IsNullOrEmpty(_tbMPower.Text)) {
                _vehicle.Motor.Power = int.Parse(_tbMPower.Text);
            }
            Wheels wheels = new Wheels();
            wheels.Wheel = new List<Wheel>();
            foreach (DataGridViewRow dr in dgvWheels.Rows) {
                Wheel item = new Wheel();
                if (dr.Cells[0].Value != null) {
                    item.Size = int.Parse(dr.Cells[0].Value.ToString());
                    item.Pressure = int.Parse(dr.Cells[1].Value.ToString());
                    wheels.Wheel.Add(item);
                }
            }
            Form1._form.ChangeDataGridView(null, _vehicle);
            this.Close();
        }
    }
}
