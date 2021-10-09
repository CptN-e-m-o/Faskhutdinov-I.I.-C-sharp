using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class Hydroplane
    {
        /// <summary>
        /// Левая координата отрисовки самолёта
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки самолёта
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки самолёта
        /// </summary>
        private readonly int planeWidth = 150;
        /// <summary>
        /// Высота отрисовки самолёта
        /// </summary>
        private readonly int planeHeight = 80;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес самолёта
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
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
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего поплавка</param>
        /// <param name="sideSpoiler">Признак наличия боковых поплавка</param>
        /// <param name="backSpoiler">Признак наличия заднего поплавка</param>
        
        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool frontFloat, bool sideFloat, bool backFloat)
        {
            MaxSpeed = maxSpeed;

            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontFloat = frontFloat;
            SideFloat = sideFloat;
            BackFloat = backFloat;
           
        }
        /// <summary>
        /// Установка позиции самолёта
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;

            }
        }
        /// <summary>
        /// Отрисовка самолёта
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush MainColorBrush = new SolidBrush(MainColor);
            //Отрисовка переднего поплавка самолёта
            Brush ffloat = new SolidBrush(DopColor);
            if (FrontFloat)
            {
                g.DrawEllipse(pen, _startPosX + 100, _startPosY + 50, 20, 10);
                g.DrawLine(pen, _startPosX + 110, _startPosY + 50, _startPosX + 110, _startPosY+35);
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
                g.DrawLine(pen, _startPosX + 13, _startPosY + 50, _startPosX +13, _startPosY + 33);
                g.FillEllipse(ffloat, _startPosX + 3, _startPosY + 50, 20, 10);
            }
            //Отрисовка основного корпуса самолёта
            //Границы самолёта
            g.DrawEllipse(pen, _startPosX, _startPosY+17, 130, 22);
            g.DrawLine(pen, _startPosX + 5, _startPosY + 20, _startPosX + 30, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 5, _startPosY + 20, _startPosX + 5, _startPosY - 10);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 20, _startPosX + 5, _startPosY - 10);

            //Кабина
            g.DrawLine(pen, _startPosX + 105, _startPosY+20, _startPosX + 105, _startPosY + 37);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 20, _startPosX + 135, _startPosY + 27);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 37, _startPosX + 135, _startPosY + 27);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 27, _startPosX + 140, _startPosY + 27);

            //Шасси
            g.DrawEllipse(pen, _startPosX + 90, _startPosY + 52, 5, 5);
            g.DrawEllipse(pen, _startPosX + 30, _startPosY + 52, 5, 5);
            g.DrawEllipse(pen, _startPosX + 25, _startPosY + 52, 5, 5);
            g.DrawLine(pen, _startPosX + 92, _startPosY +52, _startPosX + 92, _startPosY + 37);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 52, _startPosX + 30, _startPosY + 37);
            //Крылья

            g.FillEllipse(MainColorBrush, _startPosX + 40, _startPosY + 25, 35, 5);

            //Двигатель
            g.FillEllipse(MainColorBrush, _startPosX + 10, _startPosY+15,25, 8);
        }
    }
}
