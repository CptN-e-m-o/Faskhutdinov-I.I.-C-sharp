using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes 
{
    internal class AirfieldAlreadyHaveException : Exception
    {
        /// <summary>
        /// Класс-ошибка "Если на парковке уже есть самолёт с такими же характеристиками"
        /// </summary>
        public AirfieldAlreadyHaveException() : base("На парковке уже есть такой транспорт")
        { }
    }
}
