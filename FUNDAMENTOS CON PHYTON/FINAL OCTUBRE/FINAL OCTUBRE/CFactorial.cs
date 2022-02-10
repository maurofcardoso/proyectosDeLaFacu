using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CFactorial
	{
		public CFactorial()
		{
		}
		public int factorial (int num) {
			if (num == 0) {
				return 1;
			}
			else {
				if (num == 1) {
					return 1;
				}
				else {
					return num + factorial (num -1);
				}
			}
		}
		protected double cantPares (int [ ] numeros, int pos = 0) {
			double cont = 0;
			if (pos == numeros.Length) {
				return cont;
			}
			else {
				if (numeros [pos] %2 == 0) {
					cont++;
				}
				return cont += cantPares (numeros, pos = pos +1);
			}
		}
		public double porcPares (int [] numeros) {
			return cantPares (numeros) * 100 / numeros.Length;
		}
		public int vocales (string x, int pos = 0) {
			ArrayList listaV = new ArrayList () {'a','e','i','o','u'};
			int cont = 0;
			if (pos == x.Length) {
				return cont;
			}
			else {
				if (listaV.Contains (x[pos] ) ) {
					cont++;
				}
				return cont += vocales (x, pos = pos + 1);
			}
		}
		public double promString (string [] listado) {
			return (contarTotales (listado) / listado.Length);
		}
		protected int contarTotales (string [] listado, int pos = 0) {
			int total = 0;
			if (pos == listado.Length) {
				return total;
			}
			else {
				total += listado [pos].Length;
				return total += contarTotales (listado, pos = pos+1);
			}
		}
		public bool existeApellido (ArrayList apellidos, string apellido, int pos = 0) {
			if (pos == apellidos.Count - 1) {
				if (apellido == apellidos[pos] ) {
					return true;
				}
				else {
					return false;
				}
			}
			if (apellido == apellidos[pos] ) {
				return true;
			}
			else {
				return existeApellido (apellidos, apellido, pos = pos +1);
			}
		}
	}
}
