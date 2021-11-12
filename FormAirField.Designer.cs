namespace WindowsFormsPlanes
{
    partial class FormAirField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.delAirFields = new System.Windows.Forms.Button();
            this.listBoxAirFields = new System.Windows.Forms.ListBox();
            this.addAirField = new System.Windows.Forms.Button();
            this.AirFieldTextBox = new System.Windows.Forms.TextBox();
            this.airfields = new System.Windows.Forms.Label();
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTakePlane = new System.Windows.Forms.Label();
            this.buttonParkPlane = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxButtons.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(689, 448);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.delAirFields);
            this.groupBoxButtons.Controls.Add(this.listBoxAirFields);
            this.groupBoxButtons.Controls.Add(this.addAirField);
            this.groupBoxButtons.Controls.Add(this.AirFieldTextBox);
            this.groupBoxButtons.Controls.Add(this.airfields);
            this.groupBoxButtons.Controls.Add(this.buttonTakePlane);
            this.groupBoxButtons.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxButtons.Controls.Add(this.labelPlace);
            this.groupBoxButtons.Controls.Add(this.labelTakePlane);
            this.groupBoxButtons.Controls.Add(this.buttonParkPlane);
            this.groupBoxButtons.Location = new System.Drawing.Point(696, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(105, 448);
            this.groupBoxButtons.TabIndex = 1;
            this.groupBoxButtons.TabStop = false;
            // 
            // delAirFields
            // 
            this.delAirFields.Location = new System.Drawing.Point(7, 269);
            this.delAirFields.Name = "delAirFields";
            this.delAirFields.Size = new System.Drawing.Size(93, 36);
            this.delAirFields.TabIndex = 10;
            this.delAirFields.Text = "Удалить аэродром";
            this.delAirFields.UseVisualStyleBackColor = true;
            this.delAirFields.Click += new System.EventHandler(this.delAirFields_Click);
            // 
            // listBoxAirFields
            // 
            this.listBoxAirFields.FormattingEnabled = true;
            this.listBoxAirFields.Location = new System.Drawing.Point(6, 168);
            this.listBoxAirFields.Name = "listBoxAirFields";
            this.listBoxAirFields.Size = new System.Drawing.Size(93, 95);
            this.listBoxAirFields.TabIndex = 9;
            this.listBoxAirFields.SelectedIndexChanged += new System.EventHandler(this.listBoxAirFields_SelectedIndexChanged);
            // 
            // addAirField
            // 
            this.addAirField.Location = new System.Drawing.Point(6, 123);
            this.addAirField.Name = "addAirField";
            this.addAirField.Size = new System.Drawing.Size(92, 39);
            this.addAirField.TabIndex = 8;
            this.addAirField.Text = "Добавить аэродром";
            this.addAirField.UseVisualStyleBackColor = true;
            this.addAirField.Click += new System.EventHandler(this.addAirField_Click);
            // 
            // AirFieldTextBox
            // 
            this.AirFieldTextBox.Location = new System.Drawing.Point(8, 40);
            this.AirFieldTextBox.Name = "AirFieldTextBox";
            this.AirFieldTextBox.Size = new System.Drawing.Size(93, 20);
            this.AirFieldTextBox.TabIndex = 7;
            // 
            // airfields
            // 
            this.airfields.AutoSize = true;
            this.airfields.Location = new System.Drawing.Point(22, 24);
            this.airfields.Name = "airfields";
            this.airfields.Size = new System.Drawing.Size(69, 13);
            this.airfields.TabIndex = 6;
            this.airfields.Text = "Аэродромы:";
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(6, 419);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(92, 23);
            this.buttonTakePlane.TabIndex = 5;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(55, 399);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBoxNumber.TabIndex = 4;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 399);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 3;
            this.labelPlace.Text = "Место:";
            // 
            // labelTakePlane
            // 
            this.labelTakePlane.AutoSize = true;
            this.labelTakePlane.Location = new System.Drawing.Point(6, 382);
            this.labelTakePlane.Name = "labelTakePlane";
            this.labelTakePlane.Size = new System.Drawing.Size(95, 13);
            this.labelTakePlane.TabIndex = 2;
            this.labelTakePlane.Text = "Забрать самолёт";
            // 
            // buttonParkPlane
            // 
            this.buttonParkPlane.Location = new System.Drawing.Point(6, 311);
            this.buttonParkPlane.Name = "buttonParkPlane";
            this.buttonParkPlane.Size = new System.Drawing.Size(92, 68);
            this.buttonParkPlane.TabIndex = 0;
            this.buttonParkPlane.Text = "Припарковать самолёт";
            this.buttonParkPlane.UseVisualStyleBackColor = true;
            this.buttonParkPlane.Click += new System.EventHandler(this.buttonParkPlane_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt file | *.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt file | *.txt";
            // 
            // FormAirField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormAirField";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelTakePlane;
        private System.Windows.Forms.Button buttonParkPlane;
        private System.Windows.Forms.Button delAirFields;
        private System.Windows.Forms.ListBox listBoxAirFields;
        private System.Windows.Forms.Button addAirField;
        private System.Windows.Forms.TextBox AirFieldTextBox;
        private System.Windows.Forms.Label airfields;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}