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
    public partial class FormAirField : Form
    {
        /// <summary>
        /// Объект от класса-аэродрома
        /// </summary>
        private readonly AirFieldCollection airfieldCollection;
        public FormAirField()
        {
            InitializeComponent();
            airfieldCollection = new AirFieldCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxAirFields.SelectedIndex;
            listBoxAirFields.Items.Clear();
            for (int i = 0; i < airfieldCollection.Keys.Count; i++)
            {
                listBoxAirFields.Items.Add(airfieldCollection.Keys[i]);
            }
            if (listBoxAirFields.Items.Count > 0 && (index == -1 || index >=
            listBoxAirFields.Items.Count))
            {
                listBoxAirFields.SelectedIndex = 0;
            }
            else if (listBoxAirFields.Items.Count > 0 && index > -1 && index <
            listBoxAirFields.Items.Count)
            {
                listBoxAirFields.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxAirFields.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width,
                pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                airfieldCollection[listBoxAirFields.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addAirField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AirFieldTextBox.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            airfieldCollection.AddParking(AirFieldTextBox.Text);
            ReloadLevels();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delAirFields_Click(object sender, EventArgs e)
        {
            if (listBoxAirFields.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку { listBoxAirFields.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
{
                    airfieldCollection.DelParking(AirFieldTextBox.Text);

                    ReloadLevels();

                }
            }
        }

        private void AddTransport(Vehicle transport)
        {
            if (transport != null && listBoxAirFields.SelectedIndex > -1)
            {
                if ((airfieldCollection[listBoxAirFields.SelectedItem.ToString()]) + transport)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не удалось поставить транспорт");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать самолёт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkPlane_Click(object sender, EventArgs e)
        {
            if (listBoxAirFields.SelectedItem != null)
            {
                var typeOfTranpsortConfigForm = new PlaneConfigForm();
                typeOfTranpsortConfigForm.AddEvent(AddTransport);
                typeOfTranpsortConfigForm.Show();
            }
        }


        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гидроплан"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonParkHydroplane_Click(object sender, EventArgs e)
        {
            if (listBoxAirFields.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)

                    {

                        var car = new Hydroplane(100, 1000, dialog.Color,
                        dialogDop.Color, true, true, true);
                        if (airfieldCollection[listBoxAirFields.SelectedItem.ToString()]
+ car)
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
        }
        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxAirFields.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
            {
                var plane = airfieldCollection[listBoxAirFields.SelectedItem.ToString()] -
                Convert.ToInt32(maskedTextBoxNumber.Text);
                if (plane != null)
                {
                    FormPlane form = new FormPlane();
                    form.SetPlane(plane);
                    form.ShowDialog();
                }
                Draw();
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

    }
}