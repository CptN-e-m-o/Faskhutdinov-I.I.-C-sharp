﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    public class MyPlane : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолёта
        /// </summary>
        protected readonly int planeWidth = 90;
        /// <summary>
        /// Высота отрисовки самолёта
        /// </summary>
        protected readonly int planeHeight = 50;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолёта</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public MyPlane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров самолёта
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолёта</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="planeWidth">Ширина отрисовки самолёта</param>
        /// <param name="planeHeight">Высота отрисовки самолёта</param>
        protected MyPlane(int maxSpeed, float weight, Color mainColor, int planeWidth, int
        planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;
        }
        public override void MoveTransport(Direction direction)
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush MainColorBrush = new SolidBrush(MainColor);

            //Отрисовка основного корпуса самолёта
            //Границы самолёта
            g.DrawEllipse(pen, _startPosX, _startPosY + 17, 130, 22);
            g.DrawLine(pen, _startPosX + 5, _startPosY + 20, _startPosX + 30, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 5, _startPosY + 20, _startPosX + 5, _startPosY - 10);
            g.DrawLine(pen, _startPosX + 30, _startPosY + 20, _startPosX + 5, _startPosY - 10);

            //Кабина
            g.DrawLine(pen, _startPosX + 105, _startPosY + 20, _startPosX + 105, _startPosY + 37);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 20, _startPosX + 135, _startPosY + 27);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 37, _startPosX + 135, _startPosY + 27);
            g.DrawLine(pen, _startPosX + 105, _startPosY + 27, _startPosX + 140, _startPosY + 27);

            //Шасси
            g.DrawEllipse(pen, _startPosX + 90, _startPosY + 52, 5, 5);

            g.DrawEllipse(pen, _startPosX + 30, _startPosY + 52, 5, 5);
            g.DrawEllipse(pen, _startPosX + 25, _startPosY + 52, 5, 5);

            g.DrawLine(pen, _startPosX + 92, _startPosY + 52, _startPosX + 92, _startPosY + 37);

            g.DrawLine(pen, _startPosX + 30, _startPosY + 52, _startPosX + 30, _startPosY + 37);

            //Крылья

            g.FillEllipse(MainColorBrush, _startPosX + 40, _startPosY + 25, 35, 5);

            //Двигатель
            g.FillEllipse(MainColorBrush, _startPosX + 10, _startPosY + 15, 25, 8);
        }
    }
}
