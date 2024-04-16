using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string connectionString = "server=localhost;database=Pecera;user=root;password=";
            MySqlConnection connection = new(connectionString);
            string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario ORDER BY FechaIngreso DESC LIMIT 15;";
            MySqlDataAdapter adapter = new(query, connection);
            DataTable table = new();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
            dataGridView1.Columns["FechaIngreso"].ReadOnly = false;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new();
            form1.Show();
            this.Hide();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter && textBox1.Text != "")
            {
                try
                {
                    string connectionString = "server=localhost;database=Pecera;user=root;password=";
                    MySqlConnection connection = new(connectionString);
                    string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario WHERE nombre LIKE '%" + textBox1.Text + "%'";
                    MySqlDataAdapter adapter = new(query, connection);
                    DataTable table = new();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    //MessageBox.Show("Conexión 2 !");
                    connection.Close();
                    textBox1.Text = "";

                }
                catch (Exception)
                {

                    throw;
                }






            }
            else
            {
                string connectionString = "server=localhost;database=Pecera;user=root;password=";
                MySqlConnection connection = new(connectionString);
                string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario ORDER BY FechaIngreso DESC LIMIT 15;";
                MySqlDataAdapter adapter = new(query, connection);
                DataTable table = new();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                connection.Close();

            }
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = "server=localhost;database=Pecera;user=root;password=";
            MySqlConnection connection = new(connectionString);
            string query;
            string NombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;  //Aqui vemos el nombre de la celda editada
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value); //Aqui tomamos el Id
            string NuevoValor = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (NombreColumna == "activo")
            {
                NuevoValor = (NuevoValor == "True") ? "1" : "0";  //Mejor que un if
                query = "update inventario set " + NombreColumna + " =" + NuevoValor + " where id=" + id.ToString();
                //MessageBox.Show(query);
                MySqlCommand cmd1 = new(query, connection);
                connection.Open();
                cmd1.ExecuteNonQuery();
                connection.Close();
            }

            //El nuevo valor
            if(NombreColumna != "activo")
            {
                query = "update inventario set " + NombreColumna + " ='" + NuevoValor + "' where id=" + id.ToString();
                MySqlCommand cmd = new(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Editado la celda: " + NombreColumna + " con Id: " + id.ToString() + " con el nuevo valor: " + NuevoValor);
                //MessageBox.Show("¡Editado Exitosamente!");

            }
            
 
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Estás seguro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(e.Row.Cells["id"].Value);
                string query = "DELETE FROM inventario WHERE id = " + id;
                string connectionString = "server=localhost;database=Pecera;user=root;password=";
                MySqlConnection connection = new(connectionString);
                MySqlCommand cmd = new(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Borrado");
                
            }

            
        }

   
    }
}
