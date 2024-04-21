
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace Pecera
{
    public partial class Form1 : Form, IContract
    {

        public decimal tasa = 0.00m;
        public DataTable TablaTotal = new DataTable();
        public decimal MontoTotal;
        public decimal MontoTotalMoneda;
        public decimal PagoEnBolivares;
        public decimal PagoEnDolares;
        public List<Ventas> ListadoVentas = new List<Ventas>();
        public List<UpdateInv> ListadoUpdate = new List<UpdateInv>();
        public Inventario producto = new Inventario();
        public decimal CantidadAgregar { get; set; }








        public Form1()
        {

            InitializeComponent();
            //TablaTotal.Columns.Add("ID", typeof(int));
            TablaTotal.Columns.Add("NOMBRE", typeof(string));
            //TablaTotal.Columns.Add("DESCRIPCION", typeof(string));
            TablaTotal.Columns.Add("CANTIDAD", typeof(decimal));
            TablaTotal.Columns.Add("PRECIO", typeof(decimal));
            TablaTotal.Columns.Add("TOTALITEM", typeof(decimal));
            TablaTotal.Columns.Add("COD_BARRA", typeof(string));
            TablaTotal.Columns.Add("ACTIVO", typeof(bool));
            TablaTotal.Columns.Add("FECHAINGRESO", typeof(DateTime));
            string connectionString = "server=localhost;database=Pecera;user=root;password=";
            string query = "SELECT tasa FROM cambio;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tasa = reader.GetDecimal(0);
                        }
                    }
                }
                connection.Close();
                connection.Dispose();
            }
            this.Text = "Usuario:  Robert";
            CantidadAgregar = producto.Cantidad;
            label16.Text = tasa.ToString() + "_Bs/$";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            Ventas ventas = new Ventas();
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = "server=localhost;database=Pecera;user=root;password=";
                MySqlConnection connection = new MySqlConnection(connectionString);
                try
                {

                    if (textBox1.Text == "")  //Esto sirve para listar el contenido
                    {
                        string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario LIMIT 17;";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;
                        connection.Close();
                        connection.Dispose();
                        textBox8.Text = "0.00";
                        textBox9.Text = "0.00";
                        MontoTotal = 0.00m;
                        MontoTotalMoneda = 0.00m;
                        TablaTotal.Clear();
                        ListadoVentas.Clear();
                        ListadoUpdate.Clear();



                    }

                    else
                    {
                        string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario WHERE cod_barra=" + textBox1.Text + ";";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            UpdateInv nuvup = new UpdateInv();
                            foreach (DataRow row in table.Rows)
                            {
                                // Cambia el valor de la columna "cantidad" aquí. Por ejemplo, incrementamos en 1.
                                ventas.Id = Convert.ToInt32(row["ID"]);
                                ventas.Id_ventas = Convert.ToInt32(row["ID"]) + 45;
                                ventas.Usuario = 1;
                                ventas.Producto = (string)row["nombre"];
                                ventas.Cantidad = Convert.ToDecimal(textBox7.Text);
                                ventas.Precio = (decimal)row["precio"];
                                ventas.Tasa = tasa;
                                ventas.Total = (decimal)row["precio"] * ventas.Cantidad;
                                ListadoVentas.Add(ventas);
                                MontoTotal = MontoTotal + ventas.Total;
                                MontoTotalMoneda = MontoTotal / tasa;
                                MontoTotal = Math.Round(MontoTotal, 2);
                                MontoTotalMoneda = Math.Round(MontoTotalMoneda, 2);
                                DataRow filanueva = TablaTotal.NewRow();
                                //filanueva["id"] = Convert.ToInt32(row["ID"]);
                                filanueva["nombre"] = (string)row["nombre"];
                                //filanueva["descripcion"] = (string)row["descripcion"];
                                filanueva["cantidad"] = Convert.ToDecimal(textBox7.Text);
                                filanueva["precio"] = (decimal)row["precio"];
                                filanueva["TotalItem"] = (decimal)row["precio"] * Convert.ToDecimal(textBox7.Text);
                                filanueva["cod_barra"] = (string)row["cod_barra"];
                                filanueva["activo"] = true;
                                filanueva["fechaingreso"] = (DateTime)row["FechaIngreso"];
                                TablaTotal.Rows.Add(filanueva);

                                //TablaTotal.Rows.Add(inventario);




                                if (Convert.ToDecimal(row["cantidad"]) == 0)
                                {

                                    MessageBox.Show("NO quedan mas productos de este");
                                    break;
                                }
                                else
                                {
                                    row["cantidad"] = Convert.ToDecimal(row["cantidad"]) - Convert.ToDecimal(textBox7.Text);
                                    nuvup = new UpdateInv()
                                    {
                                        Id = ventas.Id,
                                        Cantidad = Convert.ToDecimal(row["cantidad"])

                                    };
                                    ListadoUpdate.Add(nuvup);
                                }
                            }

                            dataGridView1.DataSource = TablaTotal;


                            //MessageBox.Show("Conexión 2 !");

                            //MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                            //adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            //adapter.Update(table);  //Aqui actualizamos el valor 
                            //connection.Close();
                            //connection.Dispose();
                            textBox7.Text = "1";
                            textBox8.Text = MontoTotal.ToString();
                            textBox9.Text = MontoTotalMoneda.ToString("F2");






                        }
                        else
                        {
                            // Si no existe el registro, puedes manejarlo aquí
                        }

                    }

                    timer1.Start();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);

                }
                finally
                {
                    connection.Close();


                }

            }
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Window;
            dataGridView1.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            pictureBox2.Visible = true;
            button1.Visible = true;

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            pictureBox2.Visible = false;
            button1.Visible = false;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string connectionString = "server=localhost;database=Pecera;user=root;password=";
                string query = "SELECT id,nombre,descripcion,cantidad,precio,cod_barra,activo,FechaIngreso FROM inventario WHERE cod_barra=" + textBox2.Text + ";";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                producto.Id = reader.GetInt32(0);
                                producto.Nombre = reader["Nombre"].ToString();
                                producto.Descripcion = reader["Descripcion"].ToString();
                                producto.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                                producto.Precio = Convert.ToDecimal(reader["Precio"]);
                                producto.Cod_Barra = reader["Cod_Barra"].ToString();
                                producto.Activo = Convert.ToBoolean(reader["Activo"]);
                                producto.FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);

                            }
                        }
                    }
                    connection.Close();
                    connection.Dispose();
                    if (producto.Id == 0)
                    {
                        var resp = MessageBox.Show("¿Desea crear el producto?", "NO EXISTE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                        if (resp == DialogResult.Yes)
                        {

                            button1_Click(sender, e);




                        }

                    }
                    else
                    {
                        producto.Cantidad = producto.Cantidad;
                        textBox3.Text = producto.Nombre;
                        textBox4.Text = producto.Descripcion;
                        textBox5.Text = producto.Cantidad.ToString();
                        textBox6.Text = producto.Precio.ToString();
                        CantidadAgregar = producto.Cantidad;
                        Form3 form3 = new Form3(producto);
                        AddOwnedForm(form3);
                        form3.textBox1.Text = this.textBox5.Text;
                        form3.contrato = this;
                        form3.Show();

                    }
                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool hayErrores = false;
                foreach (Control control in panel3.Controls)
                {
                    if (control is TextBox && string.IsNullOrEmpty(control.Text))
                    {
                        errorProvider1.SetError(control, "Este campo no puede estar vacío.");
                        hayErrores = true;
                    }
                    else
                    {
                        errorProvider1.SetError(control, "");
                    }
                }

                if (hayErrores)
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.Clear();
                }
                else
                {
                    string connectionString = "server=localhost;database=Pecera;user=root;password=";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    string sql = "INSERT INTO inventario (nombre, descripcion,unidad,cantidad, precio,cod_barra, activo, FechaIngreso, FechaSalida) VALUES (@nombre, @descripcion,@unidad ,@cantidad, @precio,@cod_barra, @activo, CURDATE(),@FechaSalida)";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@nombre", textBox3.Text);
                    command.Parameters.AddWithValue("@descripcion", textBox4.Text);
                    command.Parameters.AddWithValue("@unidad", "Unidad");
                    command.Parameters.AddWithValue("@cantidad", textBox5.Text);
                    command.Parameters.AddWithValue("@precio", textBox6.Text);
                    command.Parameters.AddWithValue("@cod_barra", textBox2.Text);
                    command.Parameters.AddWithValue("@activo", 1);
                    command.Parameters.AddWithValue("@FechaSalida", null);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    System.Media.SystemSounds.Exclamation.Play();
                    label8.Visible = true;
                    label8.Text = "Producto cargado Exitoso";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    timer1.Enabled = true;
                    timer1.Start();


                }




            }
            catch (Exception x)
            {

                MessageBox.Show("Error, producto existe" + x);
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Solo se permite un punto decimal");
            }
            else
            {
                errorProvider1.Clear();
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            textBox8.Text = "0.00";
            textBox9.Text = "0.00";
            textBox10.Text = "0.00";
            textBox11.Text = "0.00";
            textBox12.Text = "0.00";
            textBox13.Text = "0.00";
            MontoTotal = 0.00m;
            MontoTotalMoneda = 0.00m;
            TablaTotal.Clear();
            ListadoVentas.Clear();
            ListadoUpdate.Clear();
            button3.Enabled = true;
            button3.Visible = true;
            label8.Text = "Listo escanear...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guid uniqueGuid = new Guid(Guid.NewGuid().ToString().Replace("-", ""));
            int ventasId = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0);
            //Aqui debemos leer el gridview e ingresar los elementos en tabla ventas
            string connectionString = "server=localhost;database=Pecera;user=root;password=";
            MySqlConnection connection2 = new MySqlConnection(connectionString);

            if (ListadoVentas.Count != 0 & ListadoUpdate.Count != 0)
            {
                foreach (var ventas in ListadoVentas)
                {

                    string sql = "INSERT INTO ventas (id_ventas,usuario, producto, cantidad,precio, tasa, total, fechaventa) VALUES (@id_ventas,@usuario,@producto,@cantidad,@precio,@tasa,@total,CURDATE())";
                    MySqlCommand command2 = new MySqlCommand(sql, connection2);
                    //command2.Parameters.AddWithValue("@id", ventas.Id);
                    command2.Parameters.AddWithValue("@id_ventas", ventasId);
                    command2.Parameters.AddWithValue("@usuario", ventas.Usuario);
                    command2.Parameters.AddWithValue("@producto", ventas.Producto);
                    command2.Parameters.AddWithValue("@cantidad", ventas.Cantidad);
                    command2.Parameters.AddWithValue("@precio", ventas.Precio);
                    command2.Parameters.AddWithValue("@tasa", tasa);
                    command2.Parameters.AddWithValue("@total", ventas.Total);
                    command2.Parameters.AddWithValue("@fechaventa", null);
                    connection2.Open();
                    command2.ExecuteNonQuery();
                    connection2.Close();


                }
                connection2.Dispose();

                // Establecer conexión a MySQL

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Preparar consulta UPDATE
                    string query = "UPDATE inventario SET Cantidad = @cantidad WHERE Id = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Recorrer lista y actualizar registros
                    foreach (UpdateInv updateInv in ListadoUpdate)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id", updateInv.Id);
                        command.Parameters.AddWithValue("@cantidad", updateInv.Cantidad);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                    connection2.Dispose();
                }





                ListadoUpdate.Clear();
                ListadoVentas.Clear();
                MontoTotal = 0.00m;
                MontoTotalMoneda = 0.00m;
                textBox10.Text = "0.00";
                textBox11.Text = "0.00";

                label8.Text = "Venta exitosa";
                timer1.Enabled = true;
                timer1.Start();
            }
            button3.Enabled = false;
            button3.Visible = false;





        }
        public void Ejecutar(string texto)
        {
            int cant1 = int.Parse(textBox5.Text);
            int cant2 = int.Parse(texto);
            textBox5.Text = (cant1 + cant2).ToString();


        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            //Aqui eliminamos el producto del grid y lo eliminamos del listadoventas,ListadoUpdate y del MontoTotal
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int rowNumber = dataGridView1.SelectedRows[0].Index;
                    // Preguntar confirmación antes de eliminar
                    DialogResult result = MessageBox.Show(
                        "¿Está seguro de que desea eliminar la fila " + (rowNumber + 1) + "?",
                        "Confirmación de eliminación de fila",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes & ListadoVentas.Count > 0 & ListadoUpdate.Count > 0)
                    {
                        // Eliminar la fila si el usuario confirma
                        MontoTotal = MontoTotal - ListadoVentas[rowNumber].Precio * ListadoVentas[rowNumber].Cantidad;
                        MontoTotalMoneda = MontoTotal / tasa;
                        dataGridView1.Rows.RemoveAt(rowNumber);
                        ListadoVentas.RemoveAt(rowNumber);
                        textBox8.Text = MontoTotal.ToString("F2");
                        textBox9.Text = MontoTotalMoneda.ToString("F2");

                        // ... (Opcional) Realizar acciones adicionales después de la eliminación ...
                    }
                }
            }

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PagoEnBolivares = Convert.ToDecimal(textBox10.Text);
                PagoEnDolares = Convert.ToDecimal(textBox11.Text);

                if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton1.Checked == true)
                {
                    textBox12.Text = (PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal).ToString("F2");
                    textBox13.Text = "0.00";

                }
                if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton2.Checked == true)
                {

                    textBox12.Text = "0.00";
                    textBox13.Text = ((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / tasa).ToString("F2");

                }
                if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton3.Checked == true)
                {

                    textBox12.Text = ((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / 2).ToString("F2");
                    textBox13.Text = (((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / 2) / tasa).ToString("F2");

                }


            }
        }

        private void textBox10_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox10.Text = "0.00";
            textBox11.Text = "0.00";
            textBox12.Text = "0.00";
            textBox13.Text = "0.00";

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & radioButton3.Checked == true)
            {

                decimal residuo = PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal - Convert.ToDecimal(textBox12.Text);

                textBox13.Text = (residuo / tasa).ToString("F2");


            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter & radioButton3.Checked == true)
            {

                decimal residuo = PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal - (Convert.ToDecimal(textBox13.Text) * tasa);

                textBox12.Text = residuo.ToString("F2");


            }
        }

        public void CalcularPagos()
        {
            PagoEnBolivares = Convert.ToDecimal(textBox10.Text);
            PagoEnDolares = Convert.ToDecimal(textBox11.Text);

            if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton1.Checked == true)
            {
                textBox12.Text = (PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal).ToString("F2");
                textBox13.Text = "0.00";

            }
            if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton2.Checked == true)
            {

                textBox12.Text = "0.00";
                textBox13.Text = ((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / tasa).ToString("F2");

            }
            if (MontoTotal <= PagoEnBolivares + (PagoEnDolares * tasa) & radioButton3.Checked == true)
            {

                textBox12.Text = ((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / 2).ToString("F2");
                textBox13.Text = (((PagoEnBolivares + (PagoEnDolares * tasa) - MontoTotal) / 2) / tasa).ToString("F2");

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagos();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagos();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            label8.Text = "";
            textBox1.Text = "";

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteVentas Reportvent = new ReporteVentas();
            Reportvent.Show();
            this.Hide();
        }
    }
}