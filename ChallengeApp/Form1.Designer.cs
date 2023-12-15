namespace ChallengeApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button btDownloadJson;
        private System.Windows.Forms.Button btDownloadXML;
    }
}

