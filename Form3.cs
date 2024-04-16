using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pecera
{
    public partial class Form3 : Form
    {
        public IContract contrato { get; set; }
        

        public Inventario producto3 = new Inventario();

        public Form3(Inventario pro)
        {
            InitializeComponent();
            MessageBox.Show(pro.Nombre);
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            contrato.Ejecutar(textBox1.Text);
            
      

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
