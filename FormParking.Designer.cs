namespace WindowsFormsPlanes
{
    partial class FormParking
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
            this.buttonTakePlane = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTakePlane = new System.Windows.Forms.Label();
            this.buttonParkHydroplane = new System.Windows.Forms.Button();
            this.buttonParkPlane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxButtons.SuspendLayout();
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
            this.groupBoxButtons.Controls.Add(this.buttonTakePlane);
            this.groupBoxButtons.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxButtons.Controls.Add(this.labelPlace);
            this.groupBoxButtons.Controls.Add(this.labelTakePlane);
            this.groupBoxButtons.Controls.Add(this.buttonParkHydroplane);
            this.groupBoxButtons.Controls.Add(this.buttonParkPlane);
            this.groupBoxButtons.Location = new System.Drawing.Point(696, 0);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Size = new System.Drawing.Size(105, 448);
            this.groupBoxButtons.TabIndex = 1;
            this.groupBoxButtons.TabStop = false;
            // 
            // buttonTakePlane
            // 
            this.buttonTakePlane.Location = new System.Drawing.Point(7, 151);
            this.buttonTakePlane.Name = "buttonTakePlane";
            this.buttonTakePlane.Size = new System.Drawing.Size(92, 23);
            this.buttonTakePlane.TabIndex = 5;
            this.buttonTakePlane.Text = "Забрать";
            this.buttonTakePlane.UseVisualStyleBackColor = true;
            this.buttonTakePlane.Click += new System.EventHandler(this.buttonTakePlane_Click);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(56, 121);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(36, 20);
            this.maskedTextBoxNumber.TabIndex = 4;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 121);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 3;
            this.labelPlace.Text = "Место:";
            // 
            // labelTakePlane
            // 
            this.labelTakePlane.AutoSize = true;
            this.labelTakePlane.Location = new System.Drawing.Point(7, 104);
            this.labelTakePlane.Name = "labelTakePlane";
            this.labelTakePlane.Size = new System.Drawing.Size(95, 13);
            this.labelTakePlane.TabIndex = 2;
            this.labelTakePlane.Text = "Забрать самолёт";
            // 
            // buttonParkHydroplane
            // 
            this.buttonParkHydroplane.Location = new System.Drawing.Point(7, 57);
            this.buttonParkHydroplane.Name = "buttonParkHydroplane";
            this.buttonParkHydroplane.Size = new System.Drawing.Size(92, 40);
            this.buttonParkHydroplane.TabIndex = 1;
            this.buttonParkHydroplane.Text = "Припарковать гидросамолёт";
            this.buttonParkHydroplane.UseVisualStyleBackColor = true;
            this.buttonParkHydroplane.Click += new System.EventHandler(this.buttonParkHydroplane_Click);
            // 
            // buttonParkPlane
            // 
            this.buttonParkPlane.Location = new System.Drawing.Point(7, 13);
            this.buttonParkPlane.Name = "buttonParkPlane";
            this.buttonParkPlane.Size = new System.Drawing.Size(92, 37);
            this.buttonParkPlane.TabIndex = 0;
            this.buttonParkPlane.Text = "Припарковать самолёт";
            this.buttonParkPlane.UseVisualStyleBackColor = true;
            this.buttonParkPlane.Click += new System.EventHandler(this.buttonParkPlane_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxButtons.ResumeLayout(false);
            this.groupBoxButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button buttonTakePlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelTakePlane;
        private System.Windows.Forms.Button buttonParkHydroplane;
        private System.Windows.Forms.Button buttonParkPlane;
    }
}