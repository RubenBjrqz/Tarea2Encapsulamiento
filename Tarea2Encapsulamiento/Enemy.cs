using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Encapsulamiento
{
    class Enemy
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Explode { get; set; }
        public string Move { get; set; }
        public string Shoot { get; set; }


        private string _points;
        public string Points
        {
            get
            {
                return _points;
            }
            set
            {
                if (value.Length < 100)
                {
                    _points = "Deberia dar+100";
                }
                else
                {
                    _points = "+100";
                }
            }
        }
    }
}