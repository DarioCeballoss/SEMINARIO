using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcular_vuelto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double buelto;
        
        byte quinientos;
        byte doscientos;
        byte cien;
        byte cincuenta;
        byte veinte;
        byte diez;

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            
            if (txt_costo.Text == "" && txt_efectivo.Text == "")
            {
                MessageBox.Show("INGRESE UN VALOR A CALCULAR");
            }
            else
            {
                try
                {
                    buelto = Convert.ToDouble(txt_efectivo.Text) - Convert.ToDouble(txt_costo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("INGRESE UN VALOR NUMERICO");
                }
//CALCULA BILLETES
                    
                    quinientos = Convert.ToByte(buelto / 500);
                    if(buelto%500>0)
                        doscientos = Convert.ToByte(buelto / 200);





                lbl_buelto.Text = Convert.ToString(buelto)+
                    "\n quinientos" + Convert.ToString(quinientos) +
                    "\n doscientos" + Convert.ToString(doscientos);

            }
        }
    }
}
