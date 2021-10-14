using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransport
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parking<T> where T : class, ITransport
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;
        /// <summary>
        /// 
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Размер парковки - ширина</param>
        /// <param name="picHeight">Размер парковки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется самолет
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый самолет</param>
        /// <returns></returns>
        /// 
        
        public static int operator +(Parking<T> p, T vehicle)
        {

            for (int i = 0; i < p._places.Length; i++)
            {
                
                if (p._places[i] == null)
                {

                    p._places[i] = vehicle;
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем самолет
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length)
            {
                return null;
            }
            if (p._places[index] != null)
            {
                T plane = p._places[index];
                p._places[index] = null;
                return plane;
            }
            return null;
        }
        
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            int x = 5;
            int y = 15;
            for (int i = 0; i < _places.Length; i++)
            {
                if (i % (pictureWidth / _placeSizeWidth) == 0 & i > 0)
                {
                    x = 5;
                    y += 80;
                }
              
                _places[i]?.SetPosition(x, y, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
                x += 210;
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия разметки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}

