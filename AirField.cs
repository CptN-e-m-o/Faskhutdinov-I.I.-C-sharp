using System;
using System.Collections;
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
    public class AirField<T> : IEnumerator<T>, IEnumerable<T> where T : class, ITransport
    {
        /// <summary>
        /// Список объектов, которые храним
        /// </summary>
        private readonly List<T> _places;
        /// <summary>
        /// Максимальное количество мест на парковке
        /// </summary>
        private readonly int _maxCount;
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
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int currentIndex;
        public T Current => _places[currentIndex];
        object IEnumerator.Current => _places[currentIndex];

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public AirField(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _maxCount = width * height;
            pictureWidth = picWidth;
            pictureHeight = picHeight;
            _places = new List<T>();
            currentIndex = -1;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на аэродром добавляется самолет
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="vehicle">Добавляемый самолет</param>
        /// <returns></returns>
        /// 

        
        public static bool operator +(AirField<T> p, T vehicle)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new AirfieldOverflowException();
            }
            if (p._places.Contains(vehicle))
            {
                throw new AirfieldAlreadyHaveException();
            }
            p._places.Add(vehicle);
            return true;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с аэродрома забираем самолёт
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(AirField<T> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                throw new AirfieldNotFoundException(index);
            }
            T vehicle = p._places[index];
            p._places.RemoveAt(index);
            return vehicle;
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
            for (int i = 0; i < _places.Count; i++)
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


        /// <summary>
        /// Функция получения элемента из списка
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }

        public void Sort()
        {
            _places.Sort((IComparer<T>)new PlaneComparer());
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex >= _places.Count)
            {
                Reset();
                return false;
            }
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}

