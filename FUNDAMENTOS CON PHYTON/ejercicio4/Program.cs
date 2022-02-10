using System;
using System.Collections;

namespace ejercicio4
{
	class Program
	{
		
		/*Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía. 
		Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de 
		caracteres por palabra.*/

		public static void Main(string[] args)
		{
					ArrayList lispal = new ArrayList();
					string palabra;
					int suma=0,cantpal=0;
					int empS=0;
					double prom;
					
					
			/* se ingresa la sucesión de palabras*/
			Console.WriteLine("Ingrese una palabra o espacio en blanco para finalizar");
			palabra = Console.ReadLine();
			while (palabra != "")
			 {
				palabra=palabra.ToLower();
  			   	palabra=palabra.Trim();
  				lispal.Add(palabra);
  				//cantpal++;
  				//suma+=palabra.Length;
  			   	Console.WriteLine("Longitud de " + palabra + " "+ palabra.Length);
  			   	
   				//if (palabra[0]=='s') 
   				//	empS++;
   				Console.WriteLine("Ingrese una palabra o blanco para finalizar");
   				palabra = Console.ReadLine();
              }
			
			cantpal=lispal.Count;
			foreach (string pal in lispal) {
				suma+=pal.Length;
				if (pal[0]=='s') 
   					empS++;
			}
			
			
			if (cantpal !=0)
			{
			  prom=suma/cantpal;
			  Console.WriteLine("Cantidad promedio de letras por palabra " + prom);
			  Console.WriteLine("LA cantidad de palabras que empiezan con s es :" + empS);
			}
			else
				Console.WriteLine("no se ingresaron palabras");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}