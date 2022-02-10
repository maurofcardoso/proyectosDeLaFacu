using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string pal;
			int k;
			int [] voc=new int[5]{0,0,0,0,0};
			char [] nom=new char[5]{'a','e','i','o','u'};
			Console.WriteLine("ingrese una palabra");
			pal=Console.ReadLine();
			contar(pal, ref voc);
			k=0;
			foreach (int el in voc)
			{Console.WriteLine("cantidad de letras " + nom[k] + " es " + el);
				k=k+1;
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void contar(string p, ref int [] vec)
		{
			for(int i=0;i<p.Length;i++)
			{ char c;
				c=p[i];
				switch (c)
				{
						case 'a': vec[0]=vec[0]+1;break;
						case 'e': vec[1]=vec[1]+1;break;
						case 'i': vec[2]=vec[2]+1;break;
						case 'o': vec[3]=vec[3]+1;break;
						case 'u': vec[4]=vec[4]+1;break;
				}
			}
			
		}
	}
}
	
