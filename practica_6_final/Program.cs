////////////////////////////////////////////Ejercicio_1////////////////////////////////////////////
//verificar que cada programa contiene separador /* */

using System;

namespace practica_6_1
{

    class Persona
    {
        public int cedula = 405304001-7;
        public string Apellido = "Rojas";
        public string Nombre = "Cesar";
        public byte edad = 19;

        public void imprimir()
        {


            Console.WriteLine($"Informaciones: Cedula:{cedula}, Apellido: {Apellido}, Nombre: {Nombre}, Edad: {edad}");



        }

    }

    class Profesor : Persona
    {
        int salario = 15000;
        public void escribir()
        {



            Console.WriteLine("El salario es: " + salario);


        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona myPersona = new Persona();
            Console.WriteLine("Información personal");
            myPersona.imprimir();

            Profesor Profesor = new Profesor();
            Console.WriteLine("Informacion privada del/la profesor/a");
            Profesor.cedula = 1012515403;
            Profesor.Apellido = "Griffin";
            Profesor.Nombre = "josephine";
            Profesor.edad = 29;
            Profesor.imprimir();
            Profesor.escribir();
        }
    }

}

////////////////////////////////////////////Ejercicio_2////////////////////////////////////////////

/*


using System;

namespace practica_6_2
{
    public class Contacto
    {
        public string NOMBRE;
        public string APELLIDO;
        public string CELULAR;
        public string DIR;



        public void SetContacto()
        {
            NOMBRE = Console.ReadLine();

            APELLIDO = Console.ReadLine();

            CELULAR = Console.ReadLine();

            DIR = Console.ReadLine();


        }

        public void Saludar()
        {



            Console.WriteLine($" SALUDOS, SOY; {NOMBRE} {APELLIDO}, MI NUMERO ES;  {CELULAR} RESIDO EN;  {DIR}");





        }

    }

    class misContacto
    {

        static void Main(string[] args)
        {
            Contacto LosContacto = new Contacto();
            Console.WriteLine("Ingrese la informacion de la persona: Nombre, Apellido, Numero, Direccion");
            LosContacto.SetContacto();
            LosContacto.Saludar();

            Contacto myContacto2 = new Contacto();

            Console.WriteLine("Dijite la informacion de la persona: Nombre, Apellido, Numero, Direccion");
            myContacto2.SetContacto();
            myContacto2.Saludar();

        }
    }
}
*/

////////////////////////////////////////////Ejercicio_3////////////////////////////////////////////

/*

using System;

namespace Practica_6_3
{

    public class A
    {
        public A()
        {
            Console.WriteLine("clase A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("Clase B");
        }
    }

    public class C : B
    {
        public C()
        {
            Console.WriteLine("Clase C");
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            C obj1 = new C();
            Console.ReadKey();
        }
    }


}

*/