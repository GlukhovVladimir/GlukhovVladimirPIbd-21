using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTrain
{
    class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base ("На парковке уже есть такой транспорт")
        {
        }
    }
}
