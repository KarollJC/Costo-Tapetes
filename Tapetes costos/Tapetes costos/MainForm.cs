/*
 * Created by SharpDevelop.
 * User: CC2_PC24
 * Date: 20/11/2024
 * Time: 07:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tapetes_costos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PbCempasuClick(object sender, EventArgs e)
		{
			lblFlor.Text = "Cempasúchil";
		}
		
		void PbClavelClick(object sender, EventArgs e)
		{
			lblFlor.Text = "Clavel";
		}
		
		void PbZinniaClick(object sender, EventArgs e)
		{
			lblFlor.Text = "Zinnia";		
		}
		
		void PbRosaClick(object sender, EventArgs e)
		{
			lblFlor.Text = "Rosa de Castilla";
		}
		
		//Calcular precio por bulto de aserrín
		void BtnAddBultClick(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(txtBulto.Text);
			double mult = 400;
			double result = num * mult;	
			lblCAserrin.Text = "$ " + result.ToString();
		}
		
		//Borra datos
		void TxtBorrarClick(object sender, EventArgs e)
		{
			txtCuanto.Text = "";
			txtAlimentos.Text = "";
			txtManoObra.Text = "";
			txtHora.Text = "";
			txtAlto.Text = "";
			txtAncho.Text = "";
			txtBulto.Text = "";
			txtDocenas.Text = "";
			lblCTapeteros.Text = "$ $ $";
			lblCAserrin.Text = "$ $ $";
			lblCTamano.Text = "$ $ $";
			lblCFlores.Text = "$ $ $";
			lblCTotal.Text = "$ $ $";
		}
		
		//Costo por tamaño
		void BtnAddTamClick(object sender, EventArgs e)
		{
			double alto = Convert.ToDouble(txtAlto.Text);
			double ancho = Convert.ToDouble(txtAncho.Text);
			double tam = 100;
			double ope = (alto * tam) + (ancho * tam);
			lblCTamano.Text = "$ " + ope;
		}
		
		//Costo de las docenas
		void BtnAddFlorClick(object sender, EventArgs e)
		{
			double docenas = Convert.ToDouble(txtDocenas.Text);
			double pDoce = docenas * 50;
			lblCFlores.Text = "$ " + pDoce;
			
		}
		
		//Costo de los tapeteros
		void BtnAddCuantClick(object sender, EventArgs e)
		{
			double pipol = Convert.ToDouble(txtCuanto.Text);
			double alim = Convert.ToDouble(txtAlimentos.Text);
			double mano = Convert.ToDouble(txtManoObra.Text);
			double hora = Convert.ToDouble(txtHora.Text);
			double tapeteros = (alim * pipol) + (mano * pipol) + (hora * pipol);
			lblCTapeteros.Text = "$ " + tapeteros;
		}
		
		//Costo total
		void BtnTotalClick(object sender, EventArgs e)
		{
			double num = Convert.ToDouble(txtBulto.Text);
			double mult = 400;
			double result = num * mult;
			
			double alto = Convert.ToDouble(txtAlto.Text);
			double ancho = Convert.ToDouble(txtAncho.Text);
			double tam = 100;
			double ope = (alto * tam) + (ancho * tam);
			
			double docenas = Convert.ToDouble(txtDocenas.Text);
			double pDoce = docenas * 50;
			
			double pipol = Convert.ToDouble(txtCuanto.Text);
			double alim = Convert.ToDouble(txtAlimentos.Text);
			double mano = Convert.ToDouble(txtManoObra.Text);
			double hora = Convert.ToDouble(txtHora.Text);
			double tapeteros = (alim * pipol) + (mano * pipol) + (hora * pipol);
			
			double total = result + ope + pDoce + tapeteros;
			lblCTotal.Text = "$ " + total;
		}
	}
}
