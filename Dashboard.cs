using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace VehicleManagementSystem {
    public partial class Dashboard : Form {

        // Fields
        private IconButton currentActiveButton;
        private Panel leftBorderButton;
        private readonly Rectangle originalDesignBounds;
        private bool isMaximized = false;

        private void InitializedButtonLeftBorder() {
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(10, 85);
            leftBorderButton.BackColor = System.Drawing.Color.White;
            panelMenu.Controls.Add(leftBorderButton);
        }

        public Dashboard() {
            InitializeComponent();
            InitializedButtonLeftBorder();
            ActivateButton(vehManagementBtn);
            originalDesignBounds = this.Bounds;
        }

        private void ActivateButton(object senderBtn) {
            if (senderBtn != null) {
                DeactiveButton();

                currentActiveButton = senderBtn as IconButton;
                currentActiveButton.IconSize = 60;
                currentActiveButton.BackColor = System.Drawing.Color.FromArgb(67, 74, 81);

                
                leftBorderButton.Location = new Point(0, currentActiveButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DeactiveButton() {
            if (currentActiveButton != null) {
                currentActiveButton.IconSize = 50;
                currentActiveButton.BackColor = System.Drawing.Color.Transparent;
            }
        }
        private void menuBtn_Click(object sender, EventArgs e) {
            ActivateButton(sender);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Maximize the Form
        private async void maximizeBtn_Click(object sender, EventArgs e) {
            int steps = 15;
            Rectangle startBounds = this.Bounds;
            Rectangle targetBounds;

            if (!isMaximized) {
                maximizeBtn.IconChar = IconChar.WindowRestore;
                targetBounds = Screen.FromHandle(this.Handle).WorkingArea;
                isMaximized = true;
            } else {
                maximizeBtn.IconChar = IconChar.WindowMaximize;
                Rectangle screenSize = Screen.FromHandle(this.Handle).WorkingArea;
                int centeredX = screenSize.X + (screenSize.Width - originalDesignBounds.Width) / 2;
                int centeredY = screenSize.Y + (screenSize.Height - originalDesignBounds.Height) / 2;

                targetBounds = new Rectangle(centeredX, centeredY, originalDesignBounds.Width, originalDesignBounds.Height);
                isMaximized = false;
            }

            for (int i = 1; i <= steps; i++) {
                int newWidth = startBounds.Width + (targetBounds.Width - startBounds.Width) * i / steps;
                int newHeight = startBounds.Height + (targetBounds.Height - startBounds.Height) * i / steps;
                int newX = startBounds.X + (targetBounds.X - startBounds.X) * i / steps;
                int newY = startBounds.Y + (targetBounds.Y - startBounds.Y) * i / steps;

                this.SetBounds(newX, newY, newWidth, newHeight);

                await Task.Delay(1);
            }
        }

        // Minimize Form
        private void minimizeBtn_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        // DRAG FUNCTION BOILER PLATE
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DragForm(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && !isMaximized) {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        
    }
}
