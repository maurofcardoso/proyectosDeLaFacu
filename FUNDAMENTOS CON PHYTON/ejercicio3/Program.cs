using System;

namespace ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string pal1,pal2;
			int k,tam;
			bool son;
			
			Console.WriteLine("ingrese las dos palabras a comparar");
			pal1=Console.ReadLine();
			pal2=Console.ReadLine();
			
			/* LA idea es recorrer una palabra de adelante para atras, y la segunda de atras hacia adelante, e ir conparando sus letras*/
			if (pal1.Length==pal2.Length)
			{
				son= true;
				tam=pal1.Length;
				
				k=tam-1;   /*ultima posicion de la palabra1*/
				
				for( int j=0;j<tam;j++)
				{ 
					if (pal1[j] != pal2[k])     /*si encuentro una letra distinta, ya corto el recorrido*/
					{   
						son=false;
						break;
					}
					else	
					k=k-1;
				}
				if (son)
					Console.WriteLine("\n son palindromos");
				else
					Console.WriteLine("\n no son palindromos");
					
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}