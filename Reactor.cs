using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactor
{
    internal class Reactor
    {
        public int Temperature {  get; set; }
        public int Vater {  get; set; }
        public int Radiation { get; set; }

        public Reactor(int temperature,int vater,int radiation) 
        {
            this.Temperature = temperature;
            this.Vater = vater;
            this.Radiation = radiation;
        }

    }
}
