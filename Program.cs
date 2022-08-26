using System;

namespace TPFinal_Leon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
            A partir de dichos datos informar:
                a. El mayor de los números pares.
                b. La cantidad de números impares.
                c. El menor de los números primos.
            Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true
            o false según corresponda.*/

            int n;
            int menor = 0, mayor = 0, contadorImpares = 0;
            bool banPrimo = true;
            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if (n % 2 == 0){
                    if (n > mayor)
                        mayor = n;
                }else
                    contadorImpares++;

                if(funcionPrimo(n))
                    if (banPrimo){
                        menor = n;
                        banPrimo = false;                        
                    }else if (n < menor)
                        menor = n;
                    
                    
                Console.WriteLine("Ingrese otro numero ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El menor de los numeros primos es " + menor);
            Console.WriteLine("El mayor de los numeros pares es " + mayor);
            Console.WriteLine("La cantidad de numeros impares es " + contadorImpares);
        }

        static bool funcionPrimo(int a)
        {
            int contadorPrimos = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                    contadorPrimos++;                
            }
            if (contadorPrimos == 2)
                return true;
            else
                return false;

        }
    }
}
