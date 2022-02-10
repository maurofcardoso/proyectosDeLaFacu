using System;
using System.Collections;
using System.Collections.Generic;

namespace FINAL_OCTUBRE
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cuota = 100;
			int matricula = 200;
			string [] apellidos = new string [] {"mauro"/*5*/, "fernando"/*8*/, "cardoso"/*7*/, "maxi"/*4*/, "francia"/*7*/, "sosa"/*4*/,"diaz"/*4*/};  /*39*/
			ArrayList apellidos1 = new ArrayList () {"mauro"/*5*/, "fernando"/*8*/, "cardoso"/*7*/, "maxi"/*4*/, "francia"/*7*/, "sosa"/*4*/,"diaz"/*4*/};
			Console.WriteLine (apellidos1.Count);
			int [] numeros = new int [] {1,2,3,4,5,6,7,8,9,10};
			string mau = "mauritogeniodelosgenios";
			
			
			Console.WriteLine (recursiva (apellidos, "a") );
			Console.WriteLine ();
			CFactorial fact = new CFactorial ();
			Console.WriteLine (fact.existeApellido (apellidos1, "l") );
			Console.WriteLine (fact.factorial (5) );
			Console.WriteLine ("EL PORCENTAJE DE PARES ES: {0}%",fact.porcPares (numeros) );
			Console.WriteLine (fact.vocales (mau) );
			Console.WriteLine ("EL PROMEDIO DEL ARREGLO DE STRINGS ES: {0}", fact.promString (apellidos) );
			
			
			//**************************************************************************************
			CEscuelaPrivada santaMaria = new CEscuelaPrivada (cuota, matricula, "santa maria");
			Console.WriteLine ("INGRESE LA CANTIDAD DE ALUMNOS QUE DESEA INSCRIBIR");
			bool aux = true;
			int cantidad = 0;
			do {
				try {
					cantidad = int.Parse (Console.ReadLine () );
					inscripcion (santaMaria, cantidad);
					aux = false;
				}
				catch (Exception e) {
					Console.WriteLine (e);
					Console.WriteLine ("INGRESE LA CANTIDAD DE ALUMNOS QUE DESEA INSCRIBIR");
				}
			}
			while (aux);
			Console.WriteLine ("LA CANTIDAD DE INSCRIPTOS ES DE: {0}", cantidad);
			Console.WriteLine ("EL PORCENTAJE DE ALUMNOS CON HERMANOS ES {0} %", porcentaje (santaMaria) );
			Console.WriteLine ("EL TOTAL DE MATRICULA ES {0}", montoMatricula (santaMaria, matricula) );
			Console.WriteLine ("nombre: ");
			string nom = Console.ReadLine ();
			Console.WriteLine ("dni: ");
			int doc = int.Parse (Console.ReadLine () );
			Console.WriteLine ("cantidad de hermanos: ");
			int cant = int.Parse (Console.ReadLine () );
			CAlumno alum = new CAlumno (nom, doc, cant);
			Console.WriteLine (consultarCuotaMensual (santaMaria, alum) );
			Console.WriteLine ("la recaudacion total es: {0}", santaMaria.recaudacionAnual (santaMaria) );
			
			int [] valores = new int [] {20,30,50,10,40,70,60,90,80,100};
			int [] ordenada = new int [] {10,20,30,40,50,60,70,80,90,100};
			Console.WriteLine (busquedaBinaria (ordenada, 60, 0, 10) );
			imprimir (valores);
			ordenPorIntercambio (ref valores);
			imprimir (valores);
			Console.WriteLine ("INGRESE EL VALOR DE LA ENTRADA: ");
			double valor = double.Parse (Console.ReadLine () );
			CObraDeTeatro maurito = new CObraDeTeatro ("el fantasma de la opera", valor, 10);
			for (int x = 0; x < 10; x++) {
				CEspectador aux = new CEspectador ("mauro", "cardoso", 31282983);
				maurito.venderEntrada (aux);
			}
			Console.WriteLine ("la cantidad de entradas vendidas es: {0}", (maurito.Capacidad - maurito.ButacasLibres) );
			Console.WriteLine ("la recaudacion final es: {0}", ( (maurito.Capacidad - maurito.ButacasLibres) * valor) );

			
			Console.ReadKey(true);
		}
		public static void imprimir (int [] arreglo) {
			for (int x=0; x<arreglo.Length; x++) {
				Console.WriteLine (arreglo[x] );
			}
		}
		public static void inscripcion (CEscuelaPrivada esc, int cant) {
			for (int x=0; x < cant; x++) {
				CAlumno alum = new CAlumno ("mauro", 31282983, 4);
				esc.inscribirAlu (alum);
			}
		}
		public static float porcentaje (CEscuelaPrivada esc) {
			int cont = 0;
			foreach (CAlumno x in esc.getAlumnos) {
				if (x.CantHerm > 0) {
					cont++;
				}
			}
			float porc = cont * 100 / esc.getAlumnos.Count;
			return porc;
		}
		public static double montoMatricula (CEscuelaPrivada esc, int matricula) {
			double mat = 0;
			foreach (CAlumno x in esc.getAlumnos) {
				if (x.CantHerm > 2) {
					mat += matricula * 0.8;
				}
				else {
					mat += matricula;
				}
			}
			return mat;
		}
		public static double consultarCuotaMensual (CEscuelaPrivada esc, CAlumno y) {
			foreach (CAlumno x in esc.getAlumnos) {
				if (x.Dni == y.Dni) {
					if (x.CantHerm > 2) {
						return esc.Matricula * 0.8;
					}
					else {
						return esc.Matricula;
					}
				}
			}
			return -1;
		}
		public static int recursiva (string [] apellidos, string x, int pos = 0) {
			if (pos < apellidos.Length) {
				if (x == apellidos [pos] ) {
					return pos;
				}
				else {
					return recursiva (apellidos, x, pos+1);
				}
			}
			else {
				return -1;
			}
		}
		public static bool busquedaBinaria (int [] arreglo, int elem, int primero, int ultimo) {
			int central = (primero + ultimo) / 2;
			if (arreglo [central] == elem) {
				return true;
			}
			else {
				if (arreglo [central] > elem) {
					ultimo = central - 1;
					if (ultimo < elem) {
						return false;
					}
				}
				else {
					primero = central + 1;
					if (primero > ultimo) {
						return false;
					}
				}
			}
			return busquedaBinaria (arreglo, elem, primero, ultimo);
		}
		public static void ordenPorIntercambio ( ref int [] arreglo) {
			for (int x = 0; x < arreglo.Length; x++) {
				for (int y = x+1; y < arreglo.Length; y++) {
					if (arreglo[x] > arreglo[y] ) {
						int swap = arreglo [x];
						arreglo [x] = arreglo [y];
						arreglo [y] = swap;
					}
				}
			}
		}
		
	}
}