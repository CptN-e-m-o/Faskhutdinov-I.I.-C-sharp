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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-аэродрома
        /// </summary>
        private readonly Parking<MyPlane> airfield;
        public FormParking()
        {
            InitializeComponent();
            airfield = new Parking<MyPlane>(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            airfield.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new MyPlane(100, 1000, dialog.Color);
                if (Convert.ToBoolean(airfield + plane))
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гидроплан"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkHydroplane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Hydroplane(100, 1000, dialog.Color, dialogDop.Color,
                    true, true, true);
                    if (Convert.ToBoolean(airfield + plane))
                    {
                        Draw();
                    }
                    else
                    {

                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text != "")
            {
                var plane = airfield - Convert.ToInt32(maskedTextBoxNumber.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }


    }
}