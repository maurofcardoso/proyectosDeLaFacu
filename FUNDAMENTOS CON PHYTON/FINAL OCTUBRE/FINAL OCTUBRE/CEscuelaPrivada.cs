using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CEscuelaPrivada : CEscuela
	{
		private float cuotaMensual, matricula;
		
		public CEscuelaPrivada(float prec, float mat, string nom) : base (nom)
		{
			this.cuotaMensual = prec;
			this.matricula = mat;
		}
		public float CuotaMensual {
			set {
				cuotaMensual = value;
			}
			get {
				return cuotaMensual;
			}
		}
		public float Matricula {
			set {
				matricula = value;
			}
			get {
				return matricula;
			}
		}
	}
}
