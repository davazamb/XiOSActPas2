using System;

using UIKit;

namespace XiOSActPas2
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			double Caja, Banco, CuentasporCobrar, PagoaCredito, PagoaProveedores, Renta, Capital;
			btnCalcular.TouchUpInside += delegate {
				try
				{
					Caja = double.Parse(txtCaja.Text);
					Banco = double.Parse(txtBanco.Text);
					CuentasporCobrar = double.Parse(txtCuentasporCobrar.Text);
					PagoaCredito = double.Parse(txtPagoaCredito.Text);
					PagoaProveedores = double.Parse(txtPagoaProveedores.Text);
					Renta = double.Parse(txtRenta.Text);
					Capital = (Caja + Banco + CuentasporCobrar) - (PagoaCredito + PagoaProveedores + Renta);
					txtCapitalContable.Text = Capital.ToString();
				}
				catch (Exception ex)
				{
					MessageBox("Error", (ex.Message));
				}
			};
		}

		private void MessageBox(string Title, string message)
		{
			using (UIAlertView Alerta = new UIAlertView()) 
			{
				Alerta.Title = Title;
				Alerta.Message = message;
				Alerta.AddButton("Aceptar");
				Alerta.Show();
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
