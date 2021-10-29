using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    class Hydroplane : Plane
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия переднего поплавка
        /// </summary>
        public bool FrontFloat { private set; get; }
        /// <summary>
        /// Признак наличия среднего поплавка
        /// </summary>
        public bool SideFloat { private set; get; }
        /// <summary>
        /// Признак наличия заднего поплавка
        /// </summary>
        public bool BackFloat { private set; get; }

        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontFloat">Дополнительный цвет</param>
        /// <param name="sideFloat">Дополнительный цвет</param>
        /// <param name="backFloat">Дополнительный цвет</param>

        public Hydroplane(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool frontFloat, bool sideFloat, bool backFloat) :
base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            FrontFloat = frontFloat;
            SideFloat = sideFloat;
            BackFloat = backFloat;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush MainColorBrush = new SolidBrush(MainColor);
            //Отрисовка переднего поплавка самолёта
            Brush ffloat = new SolidBrush(DopColor);
            if (FrontFloat)
            {
                g.DrawEllipse(pen, _startPosX + 100, _startPosY + 50, 20, 10);
                g.DrawLine(pen, _startPosX + 110, _startPosY + 50, _startPosX + 110, _startPosY + 35);
                g.FillEllipse(ffloat, _startPosX + 100, _startPosY + 50, 20, 10);
            }
            //Отрисовка среднего поплавка самолёта
            if (SideFloat)
            {
                g.DrawEllipse(pen, _startPosX + 60, _startPosY + 50, 20, 10);
                g.DrawLine(pen, _startPosX + 70, _startPosY + 50, _startPosX + 70, _startPosY + 38);
                g.FillEllipse(ffloat, _startPosX + 60, _startPosY + 50, 20, 10);
            }
            //Отрисовка заднего поплавка самолёта
            if (BackFloat)
            {
                g.DrawEllipse(pen, _startPosX + 3, _startPosY + 50, 20, 10);
                g.DrawLine(pen, _startPosX + 13, _startPosY + 50, _startPosX + 13, _startPosY + 33);
                g.FillEllipse(ffloat, _startPosX + 3, _startPosY + 50, 20, 10);
            }

            base.DrawTransport(g);
        }
    }
}
