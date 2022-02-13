using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_19_Wpf.Models
{
    static class CircleLength
    {
        public static double Calculate(double a) => Math.Round((2 * Math.PI * a), 2);
    }
}
