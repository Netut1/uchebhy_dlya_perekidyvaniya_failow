namespace PhoneStationModel
{
    // Визуальная копия окна SimulationForm: поле, АТС, линии и абоненты собраны из элементов в конструкторе форм. Логики, таймера и обработчиков нет.
    partial class SimulationDesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer? components = null;

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
            this.flowLayoutPanelToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonAddPhone = new System.Windows.Forms.Button();
            this.buttonAddHandset = new System.Windows.Forms.Button();
            this.panelField = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelNumberP1 = new System.Windows.Forms.Label();
            this.labelNumberP2 = new System.Windows.Forms.Label();
            this.labelNumberP3 = new System.Windows.Forms.Label();
            this.labelNumberP4 = new System.Windows.Forms.Label();
            this.labelNumberH1 = new System.Windows.Forms.Label();
            this.labelNumberH2 = new System.Windows.Forms.Label();
            this.labelNumberH3 = new System.Windows.Forms.Label();
            this.labelNumberH4 = new System.Windows.Forms.Label();
            this.panelH1 = new System.Windows.Forms.Panel();
            this.panelH2 = new System.Windows.Forms.Panel();
            this.panelH3 = new System.Windows.Forms.Panel();
            this.panelH4 = new System.Windows.Forms.Panel();
            this.labelPhoneP1 = new System.Windows.Forms.Label();
            this.labelPhoneP2 = new System.Windows.Forms.Label();
            this.labelPhoneP3 = new System.Windows.Forms.Label();
            this.labelPhoneP4 = new System.Windows.Forms.Label();
            this.labelAtcLoad1 = new System.Windows.Forms.Label();
            this.labelAtcLoad2 = new System.Windows.Forms.Label();
            this.labelAtcLoad3 = new System.Windows.Forms.Label();
            this.labelAtcLoad4 = new System.Windows.Forms.Label();
            this.labelAtc1 = new System.Windows.Forms.Label();
            this.labelAtc2 = new System.Windows.Forms.Label();
            this.labelAtc3 = new System.Windows.Forms.Label();
            this.labelAtc4 = new System.Windows.Forms.Label();
            this.labelLinkTop = new System.Windows.Forms.Label();
            this.labelLinkRight = new System.Windows.Forms.Label();
            this.labelLinkBottom = new System.Windows.Forms.Label();
            this.labelLinkLeft = new System.Windows.Forms.Label();
            this.panelWireTop = new System.Windows.Forms.Panel();
            this.panelWireRight = new System.Windows.Forms.Panel();
            this.panelWireBottom = new System.Windows.Forms.Panel();
            this.panelWireLeft = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanelToolbar.SuspendLayout();
            this.panelField.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelToolbar
            // 
            this.flowLayoutPanelToolbar.BackColor = System.Drawing.Color.FromArgb(232, 235, 240);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonAuto);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonStop);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonAddPhone);
            this.flowLayoutPanelToolbar.Controls.Add(this.buttonAddHandset);
            this.flowLayoutPanelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelToolbar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelToolbar.Name = "flowLayoutPanelToolbar";
            this.flowLayoutPanelToolbar.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelToolbar.Size = new System.Drawing.Size(1184, 52);
            this.flowLayoutPanelToolbar.TabIndex = 1;
            this.flowLayoutPanelToolbar.WrapContents = false;
            // 
            // buttonAuto
            // 
            this.buttonAuto.Enabled = false;
            this.buttonAuto.Location = new System.Drawing.Point(11, 11);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(165, 34);
            this.buttonAuto.TabIndex = 2;
            this.buttonAuto.Text = "Продолжить звонки";
            this.buttonAuto.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(182, 11);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(90, 34);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonAddPhone
            // 
            this.buttonAddPhone.Location = new System.Drawing.Point(278, 11);
            this.buttonAddPhone.Name = "buttonAddPhone";
            this.buttonAddPhone.Size = new System.Drawing.Size(150, 34);
            this.buttonAddPhone.TabIndex = 4;
            this.buttonAddPhone.Text = "Добавить телефон";
            this.buttonAddPhone.UseVisualStyleBackColor = true;
            // 
            // buttonAddHandset
            // 
            this.buttonAddHandset.Location = new System.Drawing.Point(434, 11);
            this.buttonAddHandset.Name = "buttonAddHandset";
            this.buttonAddHandset.Size = new System.Drawing.Size(150, 34);
            this.buttonAddHandset.TabIndex = 5;
            this.buttonAddHandset.Text = "Добавить трубку";
            this.buttonAddHandset.UseVisualStyleBackColor = true;
            // 
            // panelField
            // 
            this.panelField.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelField.Controls.Add(this.labelTime);
            this.panelField.Controls.Add(this.labelNumberP1);
            this.panelField.Controls.Add(this.labelNumberP2);
            this.panelField.Controls.Add(this.labelNumberP3);
            this.panelField.Controls.Add(this.labelNumberP4);
            this.panelField.Controls.Add(this.labelNumberH1);
            this.panelField.Controls.Add(this.labelNumberH2);
            this.panelField.Controls.Add(this.labelNumberH3);
            this.panelField.Controls.Add(this.labelNumberH4);
            this.panelField.Controls.Add(this.panelH1);
            this.panelField.Controls.Add(this.panelH2);
            this.panelField.Controls.Add(this.panelH3);
            this.panelField.Controls.Add(this.panelH4);
            this.panelField.Controls.Add(this.labelPhoneP1);
            this.panelField.Controls.Add(this.labelPhoneP2);
            this.panelField.Controls.Add(this.labelPhoneP3);
            this.panelField.Controls.Add(this.labelPhoneP4);
            this.panelField.Controls.Add(this.labelAtcLoad1);
            this.panelField.Controls.Add(this.labelAtcLoad2);
            this.panelField.Controls.Add(this.labelAtcLoad3);
            this.panelField.Controls.Add(this.labelAtcLoad4);
            this.panelField.Controls.Add(this.labelAtc1);
            this.panelField.Controls.Add(this.labelAtc2);
            this.panelField.Controls.Add(this.labelAtc3);
            this.panelField.Controls.Add(this.labelAtc4);
            this.panelField.Controls.Add(this.labelLinkTop);
            this.panelField.Controls.Add(this.labelLinkRight);
            this.panelField.Controls.Add(this.labelLinkBottom);
            this.panelField.Controls.Add(this.labelLinkLeft);
            this.panelField.Controls.Add(this.panelWireTop);
            this.panelField.Controls.Add(this.panelWireRight);
            this.panelField.Controls.Add(this.panelWireBottom);
            this.panelField.Controls.Add(this.panelWireLeft);
            this.panelField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelField.Location = new System.Drawing.Point(0, 52);
            this.panelField.Name = "panelField";
            this.panelField.Size = new System.Drawing.Size(1184, 731);
            this.panelField.TabIndex = 6;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = false;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(1094, 12);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(70, 24);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "08:10";
            // 
            // labelNumberP1
            // 
            this.labelNumberP1.AutoSize = true;
            this.labelNumberP1.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberP1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberP1.ForeColor = System.Drawing.Color.Black;
            this.labelNumberP1.Location = new System.Drawing.Point(162, 127);
            this.labelNumberP1.Name = "labelNumberP1";
            this.labelNumberP1.TabIndex = 22;
            this.labelNumberP1.Text = "1000001";
            // 
            // labelNumberP2
            // 
            this.labelNumberP2.AutoSize = true;
            this.labelNumberP2.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberP2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberP2.ForeColor = System.Drawing.Color.Black;
            this.labelNumberP2.Location = new System.Drawing.Point(967, 132);
            this.labelNumberP2.Name = "labelNumberP2";
            this.labelNumberP2.TabIndex = 30;
            this.labelNumberP2.Text = "1000003";
            // 
            // labelNumberP3
            // 
            this.labelNumberP3.AutoSize = true;
            this.labelNumberP3.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberP3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberP3.ForeColor = System.Drawing.Color.Black;
            this.labelNumberP3.Location = new System.Drawing.Point(192, 657);
            this.labelNumberP3.Name = "labelNumberP3";
            this.labelNumberP3.TabIndex = 38;
            this.labelNumberP3.Text = "1000005";
            // 
            // labelNumberP4
            // 
            this.labelNumberP4.AutoSize = true;
            this.labelNumberP4.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberP4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberP4.ForeColor = System.Drawing.Color.Black;
            this.labelNumberP4.Location = new System.Drawing.Point(682, 637);
            this.labelNumberP4.Name = "labelNumberP4";
            this.labelNumberP4.TabIndex = 46;
            this.labelNumberP4.Text = "1000007";
            // 
            // labelNumberH1
            // 
            this.labelNumberH1.AutoSize = true;
            this.labelNumberH1.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberH1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberH1.ForeColor = System.Drawing.Color.Black;
            this.labelNumberH1.Location = new System.Drawing.Point(452, 307);
            this.labelNumberH1.Name = "labelNumberH1";
            this.labelNumberH1.TabIndex = 54;
            this.labelNumberH1.Text = "1000002";
            // 
            // labelNumberH2
            // 
            this.labelNumberH2.AutoSize = true;
            this.labelNumberH2.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberH2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberH2.ForeColor = System.Drawing.Color.Black;
            this.labelNumberH2.Location = new System.Drawing.Point(992, 472);
            this.labelNumberH2.Name = "labelNumberH2";
            this.labelNumberH2.TabIndex = 62;
            this.labelNumberH2.Text = "1000004";
            // 
            // labelNumberH3
            // 
            this.labelNumberH3.AutoSize = true;
            this.labelNumberH3.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberH3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberH3.ForeColor = System.Drawing.Color.Black;
            this.labelNumberH3.Location = new System.Drawing.Point(542, 447);
            this.labelNumberH3.Name = "labelNumberH3";
            this.labelNumberH3.TabIndex = 70;
            this.labelNumberH3.Text = "1000006";
            // 
            // labelNumberH4
            // 
            this.labelNumberH4.AutoSize = true;
            this.labelNumberH4.BackColor = System.Drawing.Color.Transparent;
            this.labelNumberH4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumberH4.ForeColor = System.Drawing.Color.Black;
            this.labelNumberH4.Location = new System.Drawing.Point(92, 417);
            this.labelNumberH4.Name = "labelNumberH4";
            this.labelNumberH4.TabIndex = 78;
            this.labelNumberH4.Text = "1000008";
            // 
            // panelH1
            // 
            this.panelH1.BackColor = System.Drawing.Color.LightGreen;
            this.panelH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelH1.Location = new System.Drawing.Point(456, 276);
            this.panelH1.Name = "panelH1";
            this.panelH1.Size = new System.Drawing.Size(28, 28);
            this.panelH1.TabIndex = 85;
            // 
            // panelH2
            // 
            this.panelH2.BackColor = System.Drawing.Color.Tomato;
            this.panelH2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelH2.Location = new System.Drawing.Point(996, 441);
            this.panelH2.Name = "panelH2";
            this.panelH2.Size = new System.Drawing.Size(28, 28);
            this.panelH2.TabIndex = 91;
            // 
            // panelH3
            // 
            this.panelH3.BackColor = System.Drawing.Color.LightGreen;
            this.panelH3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelH3.Location = new System.Drawing.Point(546, 416);
            this.panelH3.Name = "panelH3";
            this.panelH3.Size = new System.Drawing.Size(28, 28);
            this.panelH3.TabIndex = 97;
            // 
            // panelH4
            // 
            this.panelH4.BackColor = System.Drawing.Color.LightGreen;
            this.panelH4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelH4.Location = new System.Drawing.Point(96, 386);
            this.panelH4.Name = "panelH4";
            this.panelH4.Size = new System.Drawing.Size(28, 28);
            this.panelH4.TabIndex = 103;
            // 
            // labelPhoneP1
            // 
            this.labelPhoneP1.AutoSize = false;
            this.labelPhoneP1.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneP1.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneP1.ForeColor = System.Drawing.Color.LightGreen;
            this.labelPhoneP1.Location = new System.Drawing.Point(162, 88);
            this.labelPhoneP1.Name = "labelPhoneP1";
            this.labelPhoneP1.Size = new System.Drawing.Size(36, 44);
            this.labelPhoneP1.TabIndex = 111;
            this.labelPhoneP1.Text = "●";
            this.labelPhoneP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoneP2
            // 
            this.labelPhoneP2.AutoSize = false;
            this.labelPhoneP2.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneP2.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneP2.ForeColor = System.Drawing.Color.Tomato;
            this.labelPhoneP2.Location = new System.Drawing.Point(967, 93);
            this.labelPhoneP2.Name = "labelPhoneP2";
            this.labelPhoneP2.Size = new System.Drawing.Size(36, 44);
            this.labelPhoneP2.TabIndex = 121;
            this.labelPhoneP2.Text = "●";
            this.labelPhoneP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoneP3
            // 
            this.labelPhoneP3.AutoSize = false;
            this.labelPhoneP3.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneP3.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneP3.ForeColor = System.Drawing.Color.LightGreen;
            this.labelPhoneP3.Location = new System.Drawing.Point(192, 618);
            this.labelPhoneP3.Name = "labelPhoneP3";
            this.labelPhoneP3.Size = new System.Drawing.Size(36, 44);
            this.labelPhoneP3.TabIndex = 131;
            this.labelPhoneP3.Text = "●";
            this.labelPhoneP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoneP4
            // 
            this.labelPhoneP4.AutoSize = false;
            this.labelPhoneP4.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneP4.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneP4.ForeColor = System.Drawing.Color.Orange;
            this.labelPhoneP4.Location = new System.Drawing.Point(682, 598);
            this.labelPhoneP4.Name = "labelPhoneP4";
            this.labelPhoneP4.Size = new System.Drawing.Size(36, 44);
            this.labelPhoneP4.TabIndex = 141;
            this.labelPhoneP4.Text = "●";
            this.labelPhoneP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtcLoad1
            // 
            this.labelAtcLoad1.AutoSize = true;
            this.labelAtcLoad1.BackColor = System.Drawing.Color.Transparent;
            this.labelAtcLoad1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtcLoad1.ForeColor = System.Drawing.Color.White;
            this.labelAtcLoad1.Location = new System.Drawing.Point(282, 210);
            this.labelAtcLoad1.Name = "labelAtcLoad1";
            this.labelAtcLoad1.TabIndex = 150;
            this.labelAtcLoad1.Text = "0/4";
            // 
            // labelAtcLoad2
            // 
            this.labelAtcLoad2.AutoSize = true;
            this.labelAtcLoad2.BackColor = System.Drawing.Color.Transparent;
            this.labelAtcLoad2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtcLoad2.ForeColor = System.Drawing.Color.White;
            this.labelAtcLoad2.Location = new System.Drawing.Point(872, 210);
            this.labelAtcLoad2.Name = "labelAtcLoad2";
            this.labelAtcLoad2.TabIndex = 158;
            this.labelAtcLoad2.Text = "1/4";
            // 
            // labelAtcLoad3
            // 
            this.labelAtcLoad3.AutoSize = true;
            this.labelAtcLoad3.BackColor = System.Drawing.Color.Transparent;
            this.labelAtcLoad3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtcLoad3.ForeColor = System.Drawing.Color.White;
            this.labelAtcLoad3.Location = new System.Drawing.Point(872, 565);
            this.labelAtcLoad3.Name = "labelAtcLoad3";
            this.labelAtcLoad3.TabIndex = 166;
            this.labelAtcLoad3.Text = "1/4";
            // 
            // labelAtcLoad4
            // 
            this.labelAtcLoad4.AutoSize = true;
            this.labelAtcLoad4.BackColor = System.Drawing.Color.Transparent;
            this.labelAtcLoad4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtcLoad4.ForeColor = System.Drawing.Color.White;
            this.labelAtcLoad4.Location = new System.Drawing.Point(282, 565);
            this.labelAtcLoad4.Name = "labelAtcLoad4";
            this.labelAtcLoad4.TabIndex = 174;
            this.labelAtcLoad4.Text = "0/4";
            // 
            // labelAtc1
            // 
            this.labelAtc1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelAtc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAtc1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtc1.ForeColor = System.Drawing.Color.White;
            this.labelAtc1.Location = new System.Drawing.Point(278, 169);
            this.labelAtc1.Name = "labelAtc1";
            this.labelAtc1.Size = new System.Drawing.Size(38, 38);
            this.labelAtc1.TabIndex = 183;
            this.labelAtc1.Text = "АТС 1";
            this.labelAtc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtc2
            // 
            this.labelAtc2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelAtc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAtc2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtc2.ForeColor = System.Drawing.Color.White;
            this.labelAtc2.Location = new System.Drawing.Point(868, 169);
            this.labelAtc2.Name = "labelAtc2";
            this.labelAtc2.Size = new System.Drawing.Size(38, 38);
            this.labelAtc2.TabIndex = 193;
            this.labelAtc2.Text = "АТС 2";
            this.labelAtc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtc3
            // 
            this.labelAtc3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelAtc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAtc3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtc3.ForeColor = System.Drawing.Color.White;
            this.labelAtc3.Location = new System.Drawing.Point(868, 524);
            this.labelAtc3.Name = "labelAtc3";
            this.labelAtc3.Size = new System.Drawing.Size(38, 38);
            this.labelAtc3.TabIndex = 203;
            this.labelAtc3.Text = "АТС 3";
            this.labelAtc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAtc4
            // 
            this.labelAtc4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelAtc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAtc4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAtc4.ForeColor = System.Drawing.Color.White;
            this.labelAtc4.Location = new System.Drawing.Point(278, 524);
            this.labelAtc4.Name = "labelAtc4";
            this.labelAtc4.Size = new System.Drawing.Size(38, 38);
            this.labelAtc4.TabIndex = 213;
            this.labelAtc4.Text = "АТС 4";
            this.labelAtc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLinkTop
            // 
            this.labelLinkTop.AutoSize = true;
            this.labelLinkTop.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkTop.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLinkTop.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLinkTop.Location = new System.Drawing.Point(590, 194);
            this.labelLinkTop.Name = "labelLinkTop";
            this.labelLinkTop.TabIndex = 222;
            this.labelLinkTop.Text = "0/2";
            // 
            // labelLinkRight
            // 
            this.labelLinkRight.AutoSize = true;
            this.labelLinkRight.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkRight.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLinkRight.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLinkRight.Location = new System.Drawing.Point(893, 360);
            this.labelLinkRight.Name = "labelLinkRight";
            this.labelLinkRight.TabIndex = 230;
            this.labelLinkRight.Text = "1/2";
            // 
            // labelLinkBottom
            // 
            this.labelLinkBottom.AutoSize = true;
            this.labelLinkBottom.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkBottom.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLinkBottom.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLinkBottom.Location = new System.Drawing.Point(590, 549);
            this.labelLinkBottom.Name = "labelLinkBottom";
            this.labelLinkBottom.TabIndex = 238;
            this.labelLinkBottom.Text = "0/2";
            // 
            // labelLinkLeft
            // 
            this.labelLinkLeft.AutoSize = true;
            this.labelLinkLeft.BackColor = System.Drawing.Color.Transparent;
            this.labelLinkLeft.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLinkLeft.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelLinkLeft.Location = new System.Drawing.Point(303, 360);
            this.labelLinkLeft.Name = "labelLinkLeft";
            this.labelLinkLeft.TabIndex = 246;
            this.labelLinkLeft.Text = "0/2";
            // 
            // panelWireTop
            // 
            this.panelWireTop.BackColor = System.Drawing.Color.SeaGreen;
            this.panelWireTop.Location = new System.Drawing.Point(297, 187);
            this.panelWireTop.Name = "panelWireTop";
            this.panelWireTop.Size = new System.Drawing.Size(590, 3);
            this.panelWireTop.TabIndex = 252;
            // 
            // panelWireRight
            // 
            this.panelWireRight.BackColor = System.Drawing.Color.LimeGreen;
            this.panelWireRight.Location = new System.Drawing.Point(886, 188);
            this.panelWireRight.Name = "panelWireRight";
            this.panelWireRight.Size = new System.Drawing.Size(3, 355);
            this.panelWireRight.TabIndex = 257;
            // 
            // panelWireBottom
            // 
            this.panelWireBottom.BackColor = System.Drawing.Color.SeaGreen;
            this.panelWireBottom.Location = new System.Drawing.Point(297, 542);
            this.panelWireBottom.Name = "panelWireBottom";
            this.panelWireBottom.Size = new System.Drawing.Size(590, 3);
            this.panelWireBottom.TabIndex = 262;
            // 
            // panelWireLeft
            // 
            this.panelWireLeft.BackColor = System.Drawing.Color.SeaGreen;
            this.panelWireLeft.Location = new System.Drawing.Point(296, 188);
            this.panelWireLeft.Name = "panelWireLeft";
            this.panelWireLeft.Size = new System.Drawing.Size(3, 355);
            this.panelWireLeft.TabIndex = 267;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(225, 228, 235);
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.Location = new System.Drawing.Point(0, 783);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelStatus.Size = new System.Drawing.Size(1184, 28);
            this.labelStatus.TabIndex = 268;
            this.labelStatus.Text = "Состояние: автосимуляция | Абонентов: 8 | Временных: 0 | Активных вызовов: 1 | Вызовов запущено: 3 | Виртуальное время: 08:10";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SimulationDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 811);
            this.Controls.Add(this.panelField);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.flowLayoutPanelToolbar);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "SimulationDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симуляция сети АТС";
            this.flowLayoutPanelToolbar.ResumeLayout(false);
            this.panelField.ResumeLayout(false);
            this.panelField.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelToolbar;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonAddPhone;
        private System.Windows.Forms.Button buttonAddHandset;
        private System.Windows.Forms.Panel panelField;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelNumberP1;
        private System.Windows.Forms.Label labelNumberP2;
        private System.Windows.Forms.Label labelNumberP3;
        private System.Windows.Forms.Label labelNumberP4;
        private System.Windows.Forms.Label labelNumberH1;
        private System.Windows.Forms.Label labelNumberH2;
        private System.Windows.Forms.Label labelNumberH3;
        private System.Windows.Forms.Label labelNumberH4;
        private System.Windows.Forms.Panel panelH1;
        private System.Windows.Forms.Panel panelH2;
        private System.Windows.Forms.Panel panelH3;
        private System.Windows.Forms.Panel panelH4;
        private System.Windows.Forms.Label labelPhoneP1;
        private System.Windows.Forms.Label labelPhoneP2;
        private System.Windows.Forms.Label labelPhoneP3;
        private System.Windows.Forms.Label labelPhoneP4;
        private System.Windows.Forms.Label labelAtcLoad1;
        private System.Windows.Forms.Label labelAtcLoad2;
        private System.Windows.Forms.Label labelAtcLoad3;
        private System.Windows.Forms.Label labelAtcLoad4;
        private System.Windows.Forms.Label labelAtc1;
        private System.Windows.Forms.Label labelAtc2;
        private System.Windows.Forms.Label labelAtc3;
        private System.Windows.Forms.Label labelAtc4;
        private System.Windows.Forms.Label labelLinkTop;
        private System.Windows.Forms.Label labelLinkRight;
        private System.Windows.Forms.Label labelLinkBottom;
        private System.Windows.Forms.Label labelLinkLeft;
        private System.Windows.Forms.Panel panelWireTop;
        private System.Windows.Forms.Panel panelWireRight;
        private System.Windows.Forms.Panel panelWireBottom;
        private System.Windows.Forms.Panel panelWireLeft;
        private System.Windows.Forms.Label labelStatus;
    }
}
