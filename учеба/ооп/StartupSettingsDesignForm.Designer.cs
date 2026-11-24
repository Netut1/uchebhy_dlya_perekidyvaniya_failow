namespace PhoneStationModel
{
    // Визуальная копия окна настроек StartupSettingsForm, собранная из элементов в конструкторе форм. Логики и обработчиков нет.
    partial class StartupSettingsDesignForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelPhones = new System.Windows.Forms.Label();
            this.numericPhones = new System.Windows.Forms.NumericUpDown();
            this.labelHandsets = new System.Windows.Forms.Label();
            this.numericHandsets = new System.Windows.Forms.NumericUpDown();
            this.labelAtcCapacity = new System.Windows.Forms.Label();
            this.numericAtcCapacity = new System.Windows.Forms.NumericUpDown();
            this.labelLinkCapacity = new System.Windows.Forms.Label();
            this.numericLinkCapacity = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHandsets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAtcCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkCapacity)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel.Controls.Add(this.labelPhones, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.numericPhones, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelHandsets, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.numericHandsets, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelAtcCapacity, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.numericAtcCapacity, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelLinkCapacity, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.numericLinkCapacity, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(14);
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(390, 240);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.SetColumnSpan(this.flowLayoutPanelButtons, 2);
            // 
            // labelPhones
            // 
            this.labelPhones.AutoSize = true;
            this.labelPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhones.Location = new System.Drawing.Point(17, 14);
            this.labelPhones.Name = "labelPhones";
            this.labelPhones.Size = new System.Drawing.Size(240, 40);
            this.labelPhones.TabIndex = 1;
            this.labelPhones.Text = "Постоянных телефонов (круглые):";
            this.labelPhones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericPhones
            // 
            this.numericPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericPhones.Location = new System.Drawing.Point(263, 14);
            this.numericPhones.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericPhones.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numericPhones.Name = "numericPhones";
            this.numericPhones.Size = new System.Drawing.Size(110, 23);
            this.numericPhones.TabIndex = 2;
            this.numericPhones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPhones.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // labelHandsets
            // 
            this.labelHandsets.AutoSize = true;
            this.labelHandsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHandsets.Location = new System.Drawing.Point(17, 54);
            this.labelHandsets.Name = "labelHandsets";
            this.labelHandsets.Size = new System.Drawing.Size(240, 40);
            this.labelHandsets.TabIndex = 3;
            this.labelHandsets.Text = "Постоянных трубок (квадратные):";
            this.labelHandsets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericHandsets
            // 
            this.numericHandsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericHandsets.Location = new System.Drawing.Point(263, 54);
            this.numericHandsets.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericHandsets.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numericHandsets.Name = "numericHandsets";
            this.numericHandsets.Size = new System.Drawing.Size(110, 23);
            this.numericHandsets.TabIndex = 4;
            this.numericHandsets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericHandsets.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // labelAtcCapacity
            // 
            this.labelAtcCapacity.AutoSize = true;
            this.labelAtcCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAtcCapacity.Location = new System.Drawing.Point(17, 94);
            this.labelAtcCapacity.Name = "labelAtcCapacity";
            this.labelAtcCapacity.Size = new System.Drawing.Size(240, 40);
            this.labelAtcCapacity.TabIndex = 5;
            this.labelAtcCapacity.Text = "Каналов на одну АТС:";
            this.labelAtcCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericAtcCapacity
            // 
            this.numericAtcCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericAtcCapacity.Location = new System.Drawing.Point(263, 94);
            this.numericAtcCapacity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericAtcCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericAtcCapacity.Name = "numericAtcCapacity";
            this.numericAtcCapacity.Size = new System.Drawing.Size(110, 23);
            this.numericAtcCapacity.TabIndex = 6;
            this.numericAtcCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericAtcCapacity.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // labelLinkCapacity
            // 
            this.labelLinkCapacity.AutoSize = true;
            this.labelLinkCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLinkCapacity.Location = new System.Drawing.Point(17, 134);
            this.labelLinkCapacity.Name = "labelLinkCapacity";
            this.labelLinkCapacity.Size = new System.Drawing.Size(240, 40);
            this.labelLinkCapacity.TabIndex = 7;
            this.labelLinkCapacity.Text = "Каналов на связь между АТС:";
            this.labelLinkCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericLinkCapacity
            // 
            this.numericLinkCapacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericLinkCapacity.Location = new System.Drawing.Point(263, 134);
            this.numericLinkCapacity.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numericLinkCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericLinkCapacity.Name = "numericLinkCapacity";
            this.numericLinkCapacity.Size = new System.Drawing.Size(110, 23);
            this.numericLinkCapacity.TabIndex = 8;
            this.numericLinkCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericLinkCapacity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonStart);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonExit);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(17, 174);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(356, 49);
            this.flowLayoutPanelButtons.TabIndex = 9;
            // 
            // buttonStart
            // 
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonStart.Location = new System.Drawing.Point(263, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 23);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(167, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // StartupSettingsDesignForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(390, 240);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupSettingsDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки симуляции";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHandsets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAtcCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLinkCapacity)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelPhones;
        private System.Windows.Forms.NumericUpDown numericPhones;
        private System.Windows.Forms.Label labelHandsets;
        private System.Windows.Forms.NumericUpDown numericHandsets;
        private System.Windows.Forms.Label labelAtcCapacity;
        private System.Windows.Forms.NumericUpDown numericAtcCapacity;
        private System.Windows.Forms.Label labelLinkCapacity;
        private System.Windows.Forms.NumericUpDown numericLinkCapacity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
    }
}
