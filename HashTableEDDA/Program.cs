using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HashTableEDDA
{
    class Program
    {


        public class Metodos
        {
            public static void Imprimir(Hashtable hashtable)
            {
                Console.WriteLine("||Llave ||Valor        ||");
                foreach (DictionaryEntry entry in hashtable)
                {
                    Console.WriteLine("||{0}   || {1}  ||", entry.Key, entry.Value);
                }
                Console.WriteLine(" ");
            }

            public static Hashtable Modulo(Hashtable hashtable)
            {
                Console.WriteLine("Ingrese valor a guardar");
                string strvalor = Console.ReadLine();
                int valor = Convert.ToInt32(strvalor);
                int llave = (valor % 97) + 1;
                try
                {
                    hashtable.Add(llave, valor);
                    return hashtable;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Llave ocupada");
                    return hashtable;
                }
            }

            public static Hashtable Cuadrado(Hashtable hashtable)
            {
                Console.WriteLine("Ingrese valor a guardar");
                int valor = int.Parse(Console.ReadLine());
                int cuadrado = valor ^ 2;
                string mitad = Convert.ToString(valor).Substring(2);
                try
                {
                    int llave = (Convert.ToInt32(mitad) + 1);
                    hashtable.Add(llave, valor);
                    return hashtable;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Llave ocupada");
                    return hashtable;
                }
            }

            
        }

        static void Main(string[] args)
        {
            Hashtable myTable = new Hashtable();
            int menuchoice = 0;
            Console.WriteLine("Favor de usar un tope de 6 numeros");
            while (menuchoice != 6)
            {
                Console.WriteLine("||=====================================||");
                Console.WriteLine("||Búsqueda por transformacion de claves||");
                Console.WriteLine("||Seleccione una opción                ||");
                Console.WriteLine("||1. Módulo                            ||");
                Console.WriteLine("||2. Cuadrado                          ||");
                Console.WriteLine("||3. Plegamiento                       ||");
                Console.WriteLine("||4. Truncamiento                      ||");
                Console.WriteLine("||5. Imprimir tabla                    ||");
                Console.WriteLine("||6. Salir                             ||");
                Console.WriteLine("||=====================================||");

                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        Metodos.Modulo(myTable);
                        //Console.WriteLine("Thing A has been done");//modulo
                        break;
                    case 2:
                        Metodos.Cuadrado(myTable);
                        //Console.WriteLine("Thing B has been done");//cuadrado
                        break;
                    case 3:
                        Console.WriteLine("Thing C has been done");//plegamiento
                        break;
                    case 4:
                        Console.WriteLine("Thing D has been done");//truncamiento
                        break;
                    case 5:
                        Metodos.Imprimir(myTable);//imprimir
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }
            }
        }
    }
}
