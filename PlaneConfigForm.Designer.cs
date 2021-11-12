namespace WindowsFormsPlanes
{
    partial class PlaneConfigForm
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTypeOfTransport = new System.Windows.Forms.GroupBox();
            this.HydroplaneLable = new System.Windows.Forms.Label();
            this.PlaneLable = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.CheckBoxFloatFront = new System.Windows.Forms.CheckBox();
            this.CheckBoxFloatBack = new System.Windows.Forms.CheckBox();
            this.CheckBoxFloatSide = new System.Windows.Forms.CheckBox();
            this.ChooseWeight = new System.Windows.Forms.NumericUpDown();
            this.ChooseMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.WeightTransport = new System.Windows.Forms.Label();
            this.MaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxTransport = new System.Windows.Forms.PictureBox();
            this.panelTransport = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.ColorDopLable = new System.Windows.Forms.Label();
            this.ColorMainLable = new System.Windows.Forms.Label();
            this.ButtonAddTransport = new System.Windows.Forms.Button();
            this.ButtonCancelChoose = new System.Windows.Forms.Button();
            this.groupBoxTypeOfTransport.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).BeginInit();
            this.panelTransport.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeOfTransport
            // 
            this.groupBoxTypeOfTransport.Controls.Add(this.HydroplaneLable);
            this.groupBoxTypeOfTransport.Controls.Add(this.PlaneLable);
            this.groupBoxTypeOfTransport.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeOfTransport.Name = "groupBoxTypeOfTransport";
            this.groupBoxTypeOfTransport.Size = new System.Drawing.Size(203, 222);
            this.groupBoxTypeOfTransport.TabIndex = 0;
            this.groupBoxTypeOfTransport.TabStop = false;
            this.groupBoxTypeOfTransport.Text = "Тип транспорта";
            // 
            // HydroplaneLable
            // 
            this.HydroplaneLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HydroplaneLable.Location = new System.Drawing.Point(47, 133);
            this.HydroplaneLable.Name = "HydroplaneLable";
            this.HydroplaneLable.Size = new System.Drawing.Size(99, 54);
            this.HydroplaneLable.TabIndex = 1;
            this.HydroplaneLable.Text = "Гидроплан";
            this.HydroplaneLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HydroplaneLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HydroplaneLable_MouseDown);
            // 
            // PlaneLable
            // 
            this.PlaneLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlaneLable.Location = new System.Drawing.Point(47, 41);
            this.PlaneLable.Name = "PlaneLable";
            this.PlaneLable.Size = new System.Drawing.Size(99, 54);
            this.PlaneLable.TabIndex = 0;
            this.PlaneLable.Text = "Самолёт";
            this.PlaneLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlaneLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlaneLable_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.CheckBoxFloatFront);
            this.groupBoxParameters.Controls.Add(this.CheckBoxFloatBack);
            this.groupBoxParameters.Controls.Add(this.CheckBoxFloatSide);
            this.groupBoxParameters.Controls.Add(this.ChooseWeight);
            this.groupBoxParameters.Controls.Add(this.ChooseMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.WeightTransport);
            this.groupBoxParameters.Controls.Add(this.MaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 271);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(534, 131);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // CheckBoxFloatFront
            // 
            this.CheckBoxFloatFront.AutoSize = true;
            this.CheckBoxFloatFront.Location = new System.Drawing.Point(312, 30);
            this.CheckBoxFloatFront.Name = "CheckBoxFloatFront";
            this.CheckBoxFloatFront.Size = new System.Drawing.Size(178, 17);
            this.CheckBoxFloatFront.TabIndex = 7;
            this.CheckBoxFloatFront.Text = "Добавить передние поплавки";
            this.CheckBoxFloatFront.UseVisualStyleBackColor = true;
            // 
            // CheckBoxFloatBack
            // 
            this.CheckBoxFloatBack.AutoSize = true;
            this.CheckBoxFloatBack.Location = new System.Drawing.Point(312, 97);
            this.CheckBoxFloatBack.Name = "CheckBoxFloatBack";
            this.CheckBoxFloatBack.Size = new System.Drawing.Size(166, 17);
            this.CheckBoxFloatBack.TabIndex = 6;
            this.CheckBoxFloatBack.Text = "Добавить задние поплавки";
            this.CheckBoxFloatBack.UseVisualStyleBackColor = true;
            // 
            // CheckBoxFloatSide
            // 
            this.CheckBoxFloatSide.AutoSize = true;
            this.CheckBoxFloatSide.Location = new System.Drawing.Point(312, 64);
            this.CheckBoxFloatSide.Name = "CheckBoxFloatSide";
            this.CheckBoxFloatSide.Size = new System.Drawing.Size(174, 17);
            this.CheckBoxFloatSide.TabIndex = 5;
            this.CheckBoxFloatSide.Text = "Добавить боковые поплавки";
            this.CheckBoxFloatSide.UseVisualStyleBackColor = true;
            // 
            // ChooseWeight
            // 
            this.ChooseWeight.Location = new System.Drawing.Point(69, 97);
            this.ChooseWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChooseWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChooseWeight.Name = "ChooseWeight";
            this.ChooseWeight.Size = new System.Drawing.Size(52, 20);
            this.ChooseWeight.TabIndex = 4;
            this.ChooseWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ChooseMaxSpeed
            // 
            this.ChooseMaxSpeed.Location = new System.Drawing.Point(69, 46);
            this.ChooseMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChooseMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChooseMaxSpeed.Name = "ChooseMaxSpeed";
            this.ChooseMaxSpeed.Size = new System.Drawing.Size(52, 20);
            this.ChooseMaxSpeed.TabIndex = 3;
            this.ChooseMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WeightTransport
            // 
            this.WeightTransport.AutoSize = true;
            this.WeightTransport.Location = new System.Drawing.Point(37, 81);
            this.WeightTransport.Name = "WeightTransport";
            this.WeightTransport.Size = new System.Drawing.Size(29, 13);
            this.WeightTransport.TabIndex = 1;
            this.WeightTransport.Text = "Вес:";
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.AutoSize = true;
            this.MaxSpeed.Location = new System.Drawing.Point(37, 30);
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.MaxSpeed.TabIndex = 0;
            this.MaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxTransport
            // 
            this.pictureBoxTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTransport.Location = new System.Drawing.Point(25, 24);
            this.pictureBoxTransport.Name = "pictureBoxTransport";
            this.pictureBoxTransport.Size = new System.Drawing.Size(288, 163);
            this.pictureBoxTransport.TabIndex = 2;
            this.pictureBoxTransport.TabStop = false;
            // 
            // panelTransport
            // 
            this.panelTransport.AllowDrop = true;
            this.panelTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransport.Controls.Add(this.pictureBoxTransport);
            this.panelTransport.Location = new System.Drawing.Point(232, 12);
            this.panelTransport.Name = "panelTransport";
            this.panelTransport.Size = new System.Drawing.Size(336, 214);
            this.panelTransport.TabIndex = 2;
            this.panelTransport.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragDrop);
            this.panelTransport.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.ColorDopLable);
            this.groupBoxColors.Controls.Add(this.ColorMainLable);
            this.groupBoxColors.Location = new System.Drawing.Point(574, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(314, 214);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(233, 157);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(175, 157);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 3;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(111, 157);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 3;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(45, 157);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(30, 30);
            this.panelGray.TabIndex = 3;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(233, 112);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 3;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(175, 112);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(111, 112);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(45, 112);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 2;
            // 
            // ColorDopLable
            // 
            this.ColorDopLable.AllowDrop = true;
            this.ColorDopLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorDopLable.Location = new System.Drawing.Point(175, 24);
            this.ColorDopLable.Name = "ColorDopLable";
            this.ColorDopLable.Size = new System.Drawing.Size(118, 37);
            this.ColorDopLable.TabIndex = 1;
            this.ColorDopLable.Text = "Дополнительный цвет";
            this.ColorDopLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorDopLable.DragDrop += new System.Windows.Forms.DragEventHandler(this.AdditionalColorLable_DragDrop);
            this.ColorDopLable.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragEnter);
            // 
            // ColorMainLable
            // 
            this.ColorMainLable.AllowDrop = true;
            this.ColorMainLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorMainLable.Location = new System.Drawing.Point(23, 24);
            this.ColorMainLable.Name = "ColorMainLable";
            this.ColorMainLable.Size = new System.Drawing.Size(118, 37);
            this.ColorMainLable.TabIndex = 0;
            this.ColorMainLable.Text = "Базовый цвет";
            this.ColorMainLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ColorMainLable.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragDrop);
            this.ColorMainLable.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragEnter);
            // 
            // ButtonAddTransport
            // 
            this.ButtonAddTransport.Location = new System.Drawing.Point(807, 331);
            this.ButtonAddTransport.Name = "ButtonAddTransport";
            this.ButtonAddTransport.Size = new System.Drawing.Size(81, 23);
            this.ButtonAddTransport.TabIndex = 4;
            this.ButtonAddTransport.Text = "Добавить";
            this.ButtonAddTransport.UseVisualStyleBackColor = true;
            this.ButtonAddTransport.Click += new System.EventHandler(this.ButtonAddTransport_Click);
            // 
            // ButtonCancelChoose
            // 
            this.ButtonCancelChoose.Location = new System.Drawing.Point(807, 368);
            this.ButtonCancelChoose.Name = "ButtonCancelChoose";
            this.ButtonCancelChoose.Size = new System.Drawing.Size(81, 23);
            this.ButtonCancelChoose.TabIndex = 5;
            this.ButtonCancelChoose.Text = "Отменить";
            this.ButtonCancelChoose.UseVisualStyleBackColor = true;
            // 
            // PlaneConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 414);
            this.Controls.Add(this.ButtonCancelChoose);
            this.Controls.Add(this.ButtonAddTransport);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelTransport);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxTypeOfTransport);
            this.Name = "PlaneConfigForm";
            this.Text = "Выбрать транспорт";
            this.groupBoxTypeOfTransport.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).EndInit();
            this.panelTransport.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.GroupBox groupBoxTypeOfTransport;
        private System.Windows.Forms.Label HydroplaneLable;
        private System.Windows.Forms.Label PlaneLable;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox CheckBoxFloatFront;
        private System.Windows.Forms.CheckBox CheckBoxFloatBack;
        private System.Windows.Forms.CheckBox CheckBoxFloatSide;
        private System.Windows.Forms.NumericUpDown ChooseWeight;
        private System.Windows.Forms.NumericUpDown ChooseMaxSpeed;
        private System.Windows.Forms.Label WeightTransport;
        private System.Windows.Forms.Label MaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTransport;
        private System.Windows.Forms.Panel panelTransport;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label ColorDopLable;
        private System.Windows.Forms.Label ColorMainLable;
        private System.Windows.Forms.Button ButtonAddTransport;
        private System.Windows.Forms.Button ButtonCancelChoose;
    }

    
    }