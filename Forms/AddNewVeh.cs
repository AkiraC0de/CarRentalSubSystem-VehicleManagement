using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    public partial class AddNewVeh : Form {

        private Bitmap vehicleImage;

        public AddNewVeh() {
            InitializeComponent();
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e) {

        }

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {


                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    if (vehicleImage != null) {
                        vehicleImage.Dispose();
                    }

                    string fullPath = openFileDialog.FileName;
                    string fileNameOnly = System.IO.Path.GetFileName(fullPath);

                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    using (MemoryStream ms = new MemoryStream(imageBytes)) {
                        vehicleImage = new Bitmap(ms);
                    }

                    vehicleImageFilename.Text = fileNameOnly;
                }
            }
        }
    }
}
