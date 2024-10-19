using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALERTS
{
    internal class Parametro
    {
        private int numero;
        private string caption;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Caption
        {
            get { return caption; }
            set { caption = value; }
        }
        public Parametro(int numero, string c)
        {
            this.numero = numero;
            caption = c;
        }
    }
}
