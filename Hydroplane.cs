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
base(maxSpeed, weight,Color.White, 100, 60)
        {
            MainColor = mainColor;
            DopColor = dopColor;
            FrontFloat = frontFloat;
            SideFloat = sideFloat;
            BackFloat = backFloat;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Hydroplane(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                FrontFloat = Convert.ToBoolean(strs[4]);
                SideFloat = Convert.ToBoolean(strs[5]);
                BackFloat = Convert.ToBoolean(strs[6]);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return
           $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontFloat}{separator}{SideFloat}{separator}{BackFloat}";
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


        /// <summary>
        /// Метод интерфейса IEquatable для класса Crane
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Hydroplane other)
        {
            var res = (this as Plane).Equals(other as Plane);
            if (!res)
            {
                return res;
            }
            if (other == null)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (FrontFloat != other.FrontFloat)
            {
                return false;
            }
            if (SideFloat != other.SideFloat)
            {
                return false;
            }
            if (BackFloat != other.BackFloat)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Hydroplane craneObj))
            {
                return false;
            }
            else
            {
                return Equals(craneObj);
            }
        }
    }
}
