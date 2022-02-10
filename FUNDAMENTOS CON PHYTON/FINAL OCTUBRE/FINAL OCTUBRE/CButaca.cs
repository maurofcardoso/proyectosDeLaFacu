using System;
using System.Collections;

namespace FINAL_OCTUBRE
{
	public class CButaca
	{
		private int numero;
		private bool libre;
		//********************************************************************************
		public CButaca(int numero, bool libre)
		{
			this.numero = numero;
			this.libre = libre;
		}
		public int Numero {
			set {
				numero = value;
			}
			get {
				return numero;
			}
		}
		public bool Libre {
			set {
				this.libre = value;
			}
			get {
				return this.libre;
			}
		}
	}
}
