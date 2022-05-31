using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("ejemplo.txt");//usar true o false para sobreescribir
            string[] lineas = {
             "Hola",
             "Programa ejemplo",
             "Crear ficheros",
             "ITT "
             };
            foreach (string linea in lineas)
            {
                fichero.WriteLine(linea);
            }
            fichero.Close();
            Console.WriteLine("Fichero Terminado");
            Console.ReadLine();
            StreamReader archivo = new StreamReader("ejemplo.txt");
            string lineaR;
            while ((lineaR = archivo.ReadLine()) != null){ //se establece que linea es igual a la lectura del archivo
                                                           //mientras haya documento, 
                Console.Write(lineaR);
            }
            archivo.Close();

            Console.ReadLine();
        }
    }
}
