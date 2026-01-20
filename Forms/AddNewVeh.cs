using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    public partial class AddNewVeh : Form {
        public AddNewVeh() {
            InitializeComponent();

            AppConfig.SetDoubleBuffer(panelBasicInformation, true);
            AppConfig.SetDoubleBuffer(tableBasicInfo, true);
            AppConfig.SetDoubleBuffer(panelBasicInfoLeft, true);
            AppConfig.SetDoubleBuffer(panelBasicInfoRight, true);
            AppConfig.SetDoubleBuffer(panelPurchaseDetails, true);
            AppConfig.SetDoubleBuffer(panelCarRental, true);
            AppConfig.SetDoubleBuffer(tableLowerInputs, true);
            AppConfig.SetDoubleBuffer(panelMain, true);
            AppConfig.SetDoubleBuffer(panelBg, true);
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

        


    }
}
