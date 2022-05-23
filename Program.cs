using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Miscelanea
    {
        
        static void Main(string[] args)
        {
            double numero1 = 0.0;
            double numero2 = 0.0;
            double numero3 = 0.0;
            double numero4 = 0.0;

            while (true)
            {



                Console.WriteLine(" MENU ");
                Console.WriteLine("  ");
                Console.WriteLine(" Seleccione la accion que desea ejecutar  \n" +
                                  " \n1. Operadores" +
                                  " \n2. Condicionales" +
                                  " \n3. Ciclos" +
                                  " \n4. Arreglos" +
                                  " \n5. Salir");
                Console.WriteLine("  ");

                String Opciones = null;
                Opciones = Console.ReadLine().ToString();
                Console.Clear();
            while (true)
            {

            

                switch (Opciones)
                {
                    case "1":
                        Console.WriteLine("Opcion Operadores,");
                        Console.WriteLine("\n1. Area de un triangulo.");
                        Console.WriteLine("\n2. Suma de dos numeros.");
                        Console.WriteLine("\n3. Un numero elvado al cuadrado.");
                        Console.WriteLine("\n4. Conversor de euros a dólares. ");
                        Console.WriteLine("\n5. Area y perimetro de un cuadrado. ");
                        Console.WriteLine("\n6. Area y volumen de un cilindro. ");
                        Console.WriteLine("\n7. Radio, Longitud y Area de una circunferencia. ");
                        Console.WriteLine("\n8. Promedio de 3 numeros ");
                        Console.WriteLine("\n9. Oprima 0 Para regresar al Menu Principal ");
                        Console.WriteLine("  ");


                        Console.WriteLine("Seleccione la opcion que desee: ");

                        String s1 = null;
                        s1 = Console.ReadLine().ToString();
                        Console.Clear();

                        Ejercicios operadores = new Ejercicios();
                        switch (s1)
                        {
                            case "1":
                                operadores.AreaTriangulo(numero1, numero2);
                                break;

                            case "2":
                                operadores.SumaNumeros(numero1, numero2);
                                break;

                            case "3":
                                operadores.ElevadoCuadrado(numero1);
                                break;

                            case "4":
                                operadores.ConvertidorEuro(numero1);
                                break;

                            case "5":
                                operadores.PerimetroCuadrado(numero1);
                                break;

                            case "6":
                                operadores.VolumenCilindro(numero1, numero2);
                                break;

                            case "7":
                                operadores.RadioCircunferencia(numero1);
                                break;

                            case "8":
                                operadores.PromedioNumeros(numero1, numero2, numero3);
                                break;
                        }
                        break;


                    case "2":
                        Console.WriteLine("Opcion Condicionales");
                        Console.WriteLine("\n1. Numero positivo o negativo.");
                        Console.WriteLine("\n2. Saber que numero es mayor.");
                        Console.WriteLine("\n3. Numero mayor y menor de 3 numeros.");
                        Console.WriteLine("\n4. Resta o suma.");
                        Console.WriteLine("\n5. Cociente entre 2 numeros");
                        Console.WriteLine("\n6. Multiplicacion o suma.");
                        Console.WriteLine("\n7. Año bisiesto o no.");
                        Console.WriteLine("\n8. Oprima 0 Para regresar al Menu Principal ");
                        Console.WriteLine("  ");

                        Console.WriteLine("Seleccione la opcion que desee: ");

                        String s2 = null;
                        s2 = Console.ReadLine().ToString();
                        Console.Clear();


                        Ejercicios condicionales = new Ejercicios();
                        switch (s2)
                        {
                            case "1":
                                condicionales.NumeroNP(numero1);
                                break;

                            case "2":
                                condicionales.NumeroMayor(numero1, numero2, numero3);
                                break;

                            case "3":
                                condicionales.NumeroMayoroMenor(numero1, numero2, numero3);
                                break;

                            case "4":
                                condicionales.SumaResta(numero1, numero2);

                                break;

                            case "5":
                                condicionales.CocienteDosNumeors(numero1, numero2);
                                break;

                            case "6":
                                condicionales.MultioSuma(numero1, numero2);
                                break;

                            case "7":
                                condicionales.AñoBisiesto(numero1);
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Opcion Ciclos");
                        Console.WriteLine("\n1. Multiplos de 3");
                        Console.WriteLine("\n2. Numeros impares del 0-100");
                        Console.WriteLine("\n3. Numeros pares del 1-100");
                        Console.WriteLine("\n4. Cuadrados del 1-30");
                        Console.WriteLine("\n5. Suma de los 100 primeros numeros cuadrados");
                        Console.WriteLine("\n6. Numeros Comprendidos de 2 digitos");
                        Console.WriteLine("\n7. Suma de digitos");
                        Console.WriteLine("\n8. Oprima 0 Para regresar al Menu Principal ");
                        Console.WriteLine("  ");

                        Console.WriteLine("Seleccione la opcion que desee: ");

                        String s3 = null;
                        s3 = Console.ReadLine().ToString();
                        Console.Clear();

                        Ejercicios ciclos = new Ejercicios();
                        switch (s3)
                        {
                            case "1":
                                ciclos.MultiplosTres(numero1);
                                break;

                            case "2":
                                ciclos.NumerosImpares(numero1);
                                break;

                            case "3":
                                ciclos.NumerosPares(numero1);
                                break;

                            case "4":
                                ciclos.NumeroCuadrado(numero1);
                                break;

                            case "5":
                                ciclos.SumaCien(numero1);
                                break;

                            case "6":
                                ciclos.NumerosComprendidos(numero1, numero2, numero3);
                                break;

                            case "7":
                                ciclos.SumaDigitos(numero1);
                                break;
                        }
                        break;

                    case "5":
                        Console.WriteLine(" GRACIAS ");
                        Environment.Exit(0);

                        break;

                }
                Console.Clear();
            }
        }
    }
}
