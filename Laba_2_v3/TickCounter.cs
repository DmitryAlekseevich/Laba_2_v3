using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    internal class TickCounter
    {
        protected int _TicksOnStart = 0;
        protected int _TickCount = 0;
        public int TickCount
        {
            get
            {
                return _TickCount;
            }
        }
        public void Start()
        {
            _TicksOnStart = Environment.TickCount;   //Предоставляет сведения о текущей среде и платформе, а также необходимые для управления ими средства. Этот класс не наследуется.
        }
        public void Finish()
        {
            _TickCount = Environment.TickCount - _TicksOnStart;
        }
    }
}
