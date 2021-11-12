using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlanes
{
    public partial class PlaneConfigForm : Form
    {
        private Vehicle transport = null;

        public PlaneConfigForm()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            ButtonCancelChoose.Click += (object sender, EventArgs e) => { Close(); };
        }

        public Action<Vehicle> eventAddTransport;

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddTransport == null)
            {
                eventAddTransport = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddTransport += ev;
            }
        }

        private void Draw()
        {
            if (transport != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTransport.Width, pictureBoxTransport.Height);
                Graphics gr = Graphics.FromImage(bmp);
                transport.SetPosition(5, 5, pictureBoxTransport.Width, pictureBoxTransport.Height);
                transport.DrawTransport(gr);
                pictureBoxTransport.Image = bmp;
            }
        }

        private void PlaneLable_MouseDown(object sender, MouseEventArgs e)
        {
            PlaneLable.DoDragDrop(PlaneLable.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void HydroplaneLable_MouseDown(object sender, MouseEventArgs e)
        {
            HydroplaneLable.DoDragDrop(HydroplaneLable.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTransport_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолёт":
                    transport = new Plane((int)ChooseMaxSpeed.Value, (int)ChooseWeight.Value, Color.White);
                    break;
                case "Гидроплан":
                    transport = new Hydroplane((int)ChooseMaxSpeed.Value, (int)ChooseWeight.Value, Color.White, Color.White,
                        CheckBoxFloatFront.Checked, CheckBoxFloatSide.Checked, CheckBoxFloatBack.Checked);
                    break;
            }
            Draw();
        }

        private void panelTransport_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainColorLable_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainColorLable_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                transport.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void AdditionalColorLable_DragDrop(object sender, DragEventArgs e)
        {
            if (transport != null)
            {
                if (transport is Hydroplane)
                {
                    (transport as Hydroplane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void ButtonAddTransport_Click(object sender, EventArgs e)
        {
            eventAddTransport?.Invoke(transport);
            Close();
        }
    }
}

