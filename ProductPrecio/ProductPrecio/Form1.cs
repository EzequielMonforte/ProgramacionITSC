using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductPrecio
{
    public partial class Form1 : Form
    {
        ProductPrecio.Producto ListaPrecio = new ProductPrecio.Producto();
		
        public Form1()
        {

            InitializeComponent();
			
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
			txtPrecio.Text = txtPrecio.Text.TrimStart('0'); // elimina los ceros iniciales

			try
			{
				int.Parse(txtPrecio.Text);
				textBox1.Text=ListaPrecio.CargarLista(txtProducto.Text, txtPrecio.Text);
				txtPrecio.Clear();
				txtProducto.Clear();
				txtProducto.Focus();
				label3.Text = "Precio total: $"+ ListaPrecio.PrecioTotal().ToString();
			}
			catch(FormatException)
			{
				textBox1.Text = "ingrese valor numerico";
			}
            
            
        }


		//ordena alfabeticamente
		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = ListaPrecio.OrdenadoDesc(2);
		}

		//ordena por precio
		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = ListaPrecio.OrdenadoDesc(1);
		}

	}
}
