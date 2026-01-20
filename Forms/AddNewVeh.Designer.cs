using System.Drawing;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    partial class AddNewVeh {
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
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPurchaseDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panelBasicInfoLeft = new System.Windows.Forms.Panel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelBasicInfoRight = new System.Windows.Forms.Panel();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelBasicInfoHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLowerInputs = new System.Windows.Forms.TableLayoutPanel();
            this.panelCarRental = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelPurchaseDetails.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.tableBasicInfo.SuspendLayout();
            this.panelBasicInfoLeft.SuspendLayout();
            this.panelBasicInfoRight.SuspendLayout();
            this.panelBasicInfoHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.tableLowerInputs.SuspendLayout();
            this.panelCarRental.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.Color.Transparent;
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
            this.panelBg.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.tableLowerInputs);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.guna2Panel3);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label8);
            this.panelMain.CustomizableEdges.BottomLeft = false;
            this.panelMain.CustomizableEdges.BottomRight = false;
            this.panelMain.CustomizableEdges.TopRight = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(232)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelMain.Location = new System.Drawing.Point(24, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1250, 683);
            this.panelMain.TabIndex = 11;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(51, 1414);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1152, 241);
            this.guna2Panel1.TabIndex = 12;
            // 
            // panelPurchaseDetails
            // 
            this.panelPurchaseDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPurchaseDetails.BorderRadius = 20;
            this.panelPurchaseDetails.Controls.Add(this.guna2Panel5);
            this.panelPurchaseDetails.FillColor = System.Drawing.Color.White;
            this.panelPurchaseDetails.Location = new System.Drawing.Point(3, 3);
            this.panelPurchaseDetails.Name = "panelPurchaseDetails";
            this.panelPurchaseDetails.Size = new System.Drawing.Size(567, 404);
            this.panelPurchaseDetails.TabIndex = 11;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel5.CustomizableEdges.BottomLeft = false;
            this.guna2Panel5.CustomizableEdges.BottomRight = false;
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(567, 64);
            this.guna2Panel5.TabIndex = 1;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox2.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 11;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(66, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Purchase Details";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.tableBasicInfo);
            this.guna2Panel3.Controls.Add(this.panelBasicInfoHeader);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(48, 108);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1153, 448);
            this.guna2Panel3.TabIndex = 9;
            // 
            // tableBasicInfo
            // 
            this.tableBasicInfo.ColumnCount = 2;
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoLeft, 0, 0);
            this.tableBasicInfo.Controls.Add(this.panelBasicInfoRight, 1, 0);
            this.tableBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBasicInfo.Location = new System.Drawing.Point(0, 64);
            this.tableBasicInfo.Name = "tableBasicInfo";
            this.tableBasicInfo.RowCount = 1;
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBasicInfo.Size = new System.Drawing.Size(1153, 384);
            this.tableBasicInfo.TabIndex = 1;
            // 
            // panelBasicInfoLeft
            // 
            this.panelBasicInfoLeft.Controls.Add(this.guna2TextBox1);
            this.panelBasicInfoLeft.Controls.Add(this.guna2TextBox3);
            this.panelBasicInfoLeft.Controls.Add(this.label6);
            this.panelBasicInfoLeft.Controls.Add(this.label5);
            this.panelBasicInfoLeft.Controls.Add(this.label4);
            this.panelBasicInfoLeft.Controls.Add(this.guna2TextBox2);
            this.panelBasicInfoLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoLeft.Location = new System.Drawing.Point(3, 3);
            this.panelBasicInfoLeft.Name = "panelBasicInfoLeft";
            this.panelBasicInfoLeft.Size = new System.Drawing.Size(570, 378);
            this.panelBasicInfoLeft.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(36, 47);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(523, 55);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox3.BorderRadius = 10;
            this.guna2TextBox3.BorderThickness = 2;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(36, 294);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(523, 55);
            this.guna2TextBox3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label6.Location = new System.Drawing.Point(31, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manufacturer";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label5.Location = new System.Drawing.Point(31, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "License Plate Number";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Location = new System.Drawing.Point(31, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Identification Number (VIN)";
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(36, 170);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(523, 55);
            this.guna2TextBox2.TabIndex = 10;
            // 
            // panelBasicInfoRight
            // 
            this.panelBasicInfoRight.Controls.Add(this.guna2TextBox6);
            this.panelBasicInfoRight.Controls.Add(this.guna2TextBox4);
            this.panelBasicInfoRight.Controls.Add(this.guna2TextBox5);
            this.panelBasicInfoRight.Controls.Add(this.label7);
            this.panelBasicInfoRight.Controls.Add(this.guna2ComboBox1);
            this.panelBasicInfoRight.Controls.Add(this.label9);
            this.panelBasicInfoRight.Controls.Add(this.label10);
            this.panelBasicInfoRight.Controls.Add(this.label11);
            this.panelBasicInfoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBasicInfoRight.Location = new System.Drawing.Point(579, 3);
            this.panelBasicInfoRight.Name = "panelBasicInfoRight";
            this.panelBasicInfoRight.Size = new System.Drawing.Size(571, 378);
            this.panelBasicInfoRight.TabIndex = 1;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox6.BorderRadius = 10;
            this.guna2TextBox6.BorderThickness = 2;
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox6.Location = new System.Drawing.Point(298, 170);
            this.guna2TextBox6.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PlaceholderText = "";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(244, 55);
            this.guna2TextBox6.TabIndex = 24;
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox4.BorderRadius = 10;
            this.guna2TextBox4.BorderThickness = 2;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = "";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.Location = new System.Drawing.Point(19, 47);
            this.guna2TextBox4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.Size = new System.Drawing.Size(523, 55);
            this.guna2TextBox4.TabIndex = 14;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.BorderRadius = 10;
            this.guna2TextBox5.BorderThickness = 2;
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox5.Location = new System.Drawing.Point(19, 170);
            this.guna2TextBox5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PlaceholderText = "";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(250, 55);
            this.guna2TextBox5.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Model";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.BorderThickness = 2;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.IntegralHeight = false;
            this.guna2ComboBox1.ItemHeight = 50;
            this.guna2ComboBox1.Location = new System.Drawing.Point(19, 293);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(10);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(523, 56);
            this.guna2ComboBox1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label9.Location = new System.Drawing.Point(14, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Year Model";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(14, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(293, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "Color";
            // 
            // panelBasicInfoHeader
            // 
            this.panelBasicInfoHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.BorderRadius = 20;
            this.panelBasicInfoHeader.Controls.Add(this.guna2CirclePictureBox1);
            this.panelBasicInfoHeader.Controls.Add(this.label2);
            this.panelBasicInfoHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBasicInfoHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panelBasicInfoHeader.CustomizableEdges.BottomLeft = false;
            this.panelBasicInfoHeader.CustomizableEdges.BottomRight = false;
            this.panelBasicInfoHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasicInfoHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.panelBasicInfoHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBasicInfoHeader.Name = "panelBasicInfoHeader";
            this.panelBasicInfoHeader.Size = new System.Drawing.Size(1153, 64);
            this.panelBasicInfoHeader.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox1.Image = global::VehicleManagementSystem.Properties.Resources.pen_icon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Basic Vehicle Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(44, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input vehicle specifications and VIN.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label8.Location = new System.Drawing.Point(40, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 43);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bring in a New Vehicle";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.guna2CirclePictureBox3);
            this.guna2Panel2.Controls.Add(this.label15);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel2.CustomizableEdges.BottomLeft = false;
            this.guna2Panel2.CustomizableEdges.BottomRight = false;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1152, 64);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox3.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox3.TabIndex = 11;
            this.guna2CirclePictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(66, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 29);
            this.label15.TabIndex = 8;
            this.label15.Text = "Purchase Details";
            // 
            // tableLowerInputs
            // 
            this.tableLowerInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLowerInputs.ColumnCount = 2;
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Controls.Add(this.panelCarRental, 1, 0);
            this.tableLowerInputs.Controls.Add(this.panelPurchaseDetails, 0, 0);
            this.tableLowerInputs.Location = new System.Drawing.Point(51, 613);
            this.tableLowerInputs.Name = "tableLowerInputs";
            this.tableLowerInputs.RowCount = 1;
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLowerInputs.Size = new System.Drawing.Size(1146, 410);
            this.tableLowerInputs.TabIndex = 13;
            // 
            // panelCarRental
            // 
            this.panelCarRental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCarRental.BorderRadius = 20;
            this.panelCarRental.Controls.Add(this.guna2Panel6);
            this.panelCarRental.FillColor = System.Drawing.Color.White;
            this.panelCarRental.Location = new System.Drawing.Point(587, 3);
            this.panelCarRental.Name = "panelCarRental";
            this.panelCarRental.Size = new System.Drawing.Size(556, 404);
            this.panelCarRental.TabIndex = 14;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel6.BorderRadius = 20;
            this.guna2Panel6.Controls.Add(this.guna2CirclePictureBox4);
            this.guna2Panel6.Controls.Add(this.label1);
            this.guna2Panel6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.guna2Panel6.CustomizableEdges.BottomLeft = false;
            this.guna2Panel6.CustomizableEdges.BottomRight = false;
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(129)))), ((int)(((byte)(140)))));
            this.guna2Panel6.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(556, 64);
            this.guna2Panel6.TabIndex = 1;
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.FillColor = System.Drawing.Color.LightGray;
            this.guna2CirclePictureBox4.Image = global::VehicleManagementSystem.Properties.Resources.price_change_icon;
            this.guna2CirclePictureBox4.ImageRotate = 0F;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(25, 15);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(34, 33);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox4.TabIndex = 11;
            this.guna2CirclePictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Purchase Details";
            // 
            // AddNewVeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 683);
            this.Controls.Add(this.panelBg);
            this.DoubleBuffered = true;
            this.Name = "AddNewVeh";
            this.Text = "AddNewVeh";
            this.panelBg.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.panelPurchaseDetails.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.tableBasicInfo.ResumeLayout(false);
            this.panelBasicInfoLeft.ResumeLayout(false);
            this.panelBasicInfoLeft.PerformLayout();
            this.panelBasicInfoRight.ResumeLayout(false);
            this.panelBasicInfoRight.PerformLayout();
            this.panelBasicInfoHeader.ResumeLayout(false);
            this.panelBasicInfoHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.tableLowerInputs.ResumeLayout(false);
            this.panelCarRental.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelBg;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel panelBasicInfoHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private System.Windows.Forms.TableLayoutPanel tableBasicInfo;
        private System.Windows.Forms.Panel panelBasicInfoLeft;
        private System.Windows.Forms.Panel panelBasicInfoRight;
        private Guna.UI2.WinForms.Guna2Panel panelPurchaseDetails;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLowerInputs;
        private Guna.UI2.WinForms.Guna2Panel panelCarRental;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private System.Windows.Forms.Label label1;
    }
}