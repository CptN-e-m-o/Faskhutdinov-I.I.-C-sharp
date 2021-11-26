using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    /// <summary>
    /// Класс-ошибка "Если на парковке уже заняты все места"
    /// </summary>
    public class AirfieldOverflowException : Exception
    {
        public AirfieldOverflowException() : base("На аэродроме нет свободных мест")
        { }
    }
}
