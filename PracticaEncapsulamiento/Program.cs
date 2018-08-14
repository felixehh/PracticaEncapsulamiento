using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una instancia de contacto
            Contacto contacto1 = new Contacto();
            contacto1.nombre = "Felix";
            contacto1.direccion = "Veracruz S/N";
            contacto1.correoElectronico = "felix@correo.com";
            contacto1.telefonoCasa = "12345678";
            contacto1.telefonoCelular = "0987654";

            Console.WriteLine("Nombre: " + contacto1.nombre);
            Console.WriteLine("Direccion: " + contacto1.direccion);
            Console.WriteLine("Correo: " + contacto1.correoElectronico);
            Console.WriteLine("Tel. Casa: " + contacto1.telefonoCasa);
            Console.WriteLine("Tel. Celular: " + contacto1.telefonoCelular);

            Console.ReadLine();

        }
    }
}
