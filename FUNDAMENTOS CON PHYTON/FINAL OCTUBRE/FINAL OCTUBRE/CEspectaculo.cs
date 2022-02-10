using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CEspectaculo
	{
		private ArrayList capacidadButacas;
		private int capacidad;
		//***************************************************************************************
		public CEspectaculo(int capacidad)
		{
			this.capacidad = capacidad;
			this.capacidadButacas = new ArrayList ();
			for (int x = 1; x <= capacidad; x++) {
				CButaca butacas = new CButaca (x, true);
				this.capacidadButacas.Add (butacas);
			}
		}
		public int Capacidad {
			set {
				this.capacidad = value;
			}
			get {
				return this.capacidad;
			}
		}
		public ArrayList CapacidadButacas {
			get {
				return this.capacidadButacas;
			}
		}
		public void imprimir () {
			foreach (CButaca x in capacidadButacas) {
				Console.WriteLine (x.Libre);
			}
		}

	}
}
