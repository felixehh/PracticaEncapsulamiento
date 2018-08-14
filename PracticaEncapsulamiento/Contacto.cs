using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Contacto
    {
        //Auto Properties
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefonoCasa { get; set; }
        public string correoElectronico { get; set; }

        //properties
        private string _telefonoCelular;
        public string telefonoCelular
        {
            get
            {
                return _telefonoCelular;
            }
            set
            {
                if (value.Length == 10)
                {
                    _telefonoCelular = value;
                }
                else if (value.Length == 7)
                {
                    _telefonoCelular = "644" + value;
                }
                else
                {
                    Console.WriteLine("Introduce un numero de celular valido");
                }
            }
        }
    }
}
