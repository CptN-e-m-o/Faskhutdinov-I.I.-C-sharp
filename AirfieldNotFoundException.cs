using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Класс-ошибка "Если не найден автомобиль по определенному месту"
    /// </summary>
    public class AirfieldNotFoundException : Exception
    {
        public AirfieldNotFoundException(int i) : base("Не найден самолёт по месту " + i)
        { }
    }
}
