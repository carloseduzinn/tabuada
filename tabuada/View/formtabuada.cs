using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tabuada.Controller;

namespace tabuada.View
{
    public partial class formtabuada : Form
    {
        public formtabuada()
        {
            InitializeComponent();
            //estanciamento
            
            


        }


        private void txbnumero_TextChanged(object sender, EventArgs e)
        {
            tabuadaClasse tabu = new tabuadaClasse();
            tabu.CalcularTabuada(8);

            if(txbnumero.Text != string.Empty )
            {


            int i = Convert.ToInt32(txbnumero.Text );
            string resultado = tabu.CalcularTabuada(i);

            listBoxResul.Items.Add(resultado);
            }

            else { 
                
                    MessageBox.Show("Digite um numero"); 
                }
            
            

        }
    }
}
