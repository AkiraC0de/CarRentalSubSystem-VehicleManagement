namespace VehicleManagementSystem.View.Forms {
    partial class frmVehicleDetails {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleDetails));
            this.labelSubHeader = new System.Windows.Forms.Label();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureVehicle = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelVehiclePicture = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).BeginInit();
            this.panelBg.SuspendLayout();
            this.tableTop.SuspendLayout();
            this.panelVehiclePicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSubHeader
            // 
            this.labelSubHeader.AutoSize = true;
            this.labelSubHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelSubHeader.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubHeader.Location = new System.Drawing.Point(64, 23);
            this.labelSubHeader.Name = "labelSubHeader";
            this.labelSubHeader.Size = new System.Drawing.Size(119, 37);
            this.labelSubHeader.TabIndex = 0;
            this.labelSubHeader.Text = "Toyota";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.tableTop);
            this.panelMain.Controls.Add(this.labelStatus);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.backBtn);
            this.panelMain.Controls.Add(this.labelSubHeader);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(25, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1249, 683);
            this.panelMain.TabIndex = 1;
            // 
            // pictureVehicle
            // 
            this.pictureVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureVehicle.BackColor = System.Drawing.Color.Transparent;
            this.pictureVehicle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureVehicle.BackgroundImage")));
            this.pictureVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureVehicle.FillColor = System.Drawing.Color.Transparent;
            this.pictureVehicle.Image = ((System.Drawing.Image)(resources.GetObject("pictureVehicle.Image")));
            this.pictureVehicle.ImageRotate = 0F;
            this.pictureVehicle.Location = new System.Drawing.Point(30, -4);
            this.pictureVehicle.Name = "pictureVehicle";
            this.pictureVehicle.Size = new System.Drawing.Size(775, 436);
            this.pictureVehicle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureVehicle.TabIndex = 2;
            this.pictureVehicle.TabStop = false;
            // 
            // panelBg
            // 
            this.panelBg.BorderRadius = 25;
            this.panelBg.Controls.Add(this.panelMain);
            this.panelBg.CustomizableEdges.BottomLeft = false;
            this.panelBg.CustomizableEdges.BottomRight = false;
            this.panelBg.CustomizableEdges.TopRight = false;
            this.panelBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelBg.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(1274, 683);
            this.panelBg.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.BorderThickness = 4;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.Transparent;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::VehicleManagementSystem.Properties.Resources.chevron_backward_icon;
            this.backBtn.ImageSize = new System.Drawing.Size(40, 40);
            this.backBtn.Location = new System.Drawing.Point(3, 32);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(45, 45);
            this.backBtn.TabIndex = 18;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(67, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "vehicles status and specifications,";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.BorderRadius = 15;
            this.labelStatus.BorderThickness = 0;
            this.labelStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelStatus.DefaultText = "inMaintenance";
            this.labelStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.labelStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.labelStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.labelStatus.FillColor = System.Drawing.Color.Thistle;
            this.labelStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelStatus.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.labelStatus.Location = new System.Drawing.Point(178, 23);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelStatus.PlaceholderForeColor = System.Drawing.Color.Black;
            this.labelStatus.PlaceholderText = "";
            this.labelStatus.ReadOnly = true;
            this.labelStatus.SelectedText = "";
            this.labelStatus.Size = new System.Drawing.Size(170, 41);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.labelStatus.WordWrap = false;
            // 
            // tableTop
            // 
            this.tableTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableTop.BackColor = System.Drawing.Color.Transparent;
            this.tableTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableTop.ColumnCount = 2;
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.57778F));
            this.tableTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.42221F));
            this.tableTop.Controls.Add(this.panelVehiclePicture, 0, 0);
            this.tableTop.Location = new System.Drawing.Point(0, 95);
            this.tableTop.Name = "tableTop";
            this.tableTop.RowCount = 1;
            this.tableTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTop.Size = new System.Drawing.Size(1220, 443);
            this.tableTop.TabIndex = 22;
            // 
            // panelVehiclePicture
            // 
            this.panelVehiclePicture.Controls.Add(this.pictureVehicle);
            this.panelVehiclePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVehiclePicture.Location = new System.Drawing.Point(4, 4);
            this.panelVehiclePicture.Name = "panelVehiclePicture";
            this.panelVehiclePicture.Size = new System.Drawing.Size(840, 435);
            this.panelVehiclePicture.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(484, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 65);
            this.panel1.TabIndex = 23;
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 683);
            this.Controls.Add(this.panelBg);
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVehicle)).EndInit();
            this.panelBg.ResumeLayout(false);
            this.tableTop.ResumeLayout(false);
            this.panelVehiclePicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSubHeader;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2PictureBox pictureVehicle;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox labelStatus;
        private System.Windows.Forms.TableLayoutPanel tableTop;
        private Guna.UI2.WinForms.Guna2Panel panelVehiclePicture;
        private System.Windows.Forms.Panel panel1;
    }
}