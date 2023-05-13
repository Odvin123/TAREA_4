using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_ado.net
{
    
    public partial class Modi : Form
    {
        string connectionString =
            ConfigurationManager.
            ConnectionStrings["Customer_ado.net.Propiedades.Settings1.con"].
            ConnectionString;
        public Modi()
        {
            InitializeComponent();
            GetCustomer();
        }

        #region Metodos ("DAR DOBLE CLICK AQUI PARA ABRIR LOS METODOS")
        private void GetCustomer()
        {
            string queryString = "SELECT CustomerID,CompanyName,ContactName,ContactTitle," +
                "Address,City,Region,PostalCode,Country,Phone,Fax " +
                 "FROM Customers ORDER BY ContactName;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvCustomer.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private string letras()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var Charsarr = new char[4];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            return resultString;
        }
        private void Limpiartxt()
        {
            lblCustomID.Text = "ID del cliemte";
            txtNameCompany.Text = String.Empty;
            txtContactName.Text = String.Empty;
            txtContactTitle.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtRegion.Text = String.Empty;
            txtCodePostal.Text = String.Empty;
            txtCountry.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txt_Fax.Text = String.Empty;

        }

        private void IngresarCustomer()
        {
            string Letras_Azar = letras();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    string queryString = "INSERT INTO Customers(CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) " +
                        "VALUES('" + Letras_Azar + "','" + txtNameCompany.Text + "','" + txtContactName.Text + "','" + txtContactTitle.Text + "','" +
                                     txtAddress.Text + "', '" + txtCity.Text + "', '" + txtRegion.Text + "','" + txtCodePostal.Text + "','" + txtCountry.Text + "','"
                                     + txtPhone.Text + "','" + txt_Fax.Text + "' )";

                    SqlCommand cmd = new SqlCommand(queryString, connection);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente Ingresado correctamente");
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ActuCustomer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "UPDATE Customers SET CompanyName = '" + txtNameCompany.Text
                        + "', ContactName = '" + txtContactName.Text + "',ContactTitle='" + txtContactTitle.Text
                        + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',Region='" + txtRegion.Text
                        + "',PostalCode='" + txtCodePostal.Text + "',Country='" + txtCountry.Text + "',Phone='"
                        + txtPhone.Text + "',Fax='" + txt_Fax.Text + "' WHERE CustomerID = '" + lblCustomID.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado correctamente");
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void EliminarCustomers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string queryString = "DELETE FROM Customers WHERE CustomerID = '" + lblCustomID.Text + "'";
                    SqlCommand cmd = new SqlCommand(queryString, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente eliminado correctamente");
                    GetCustomer();
                }
                catch (InvalidCastException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion


        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // aqui necesito nuevas variables 
                // cambialas y editalas 
                // lo que esta en comillas no se cambian 
                //cambia el textbox y label 
                // en el form cambia la fuente de letra y movelas 
                // me avisas por cualquier cosa
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                lblCustomID.Text = row.Cells["CustomerID"].Value.ToString();
                txtNameCompany.Text = row.Cells["CompanyName"].Value.ToString();
                txtContactName.Text = row.Cells["ContactName"].Value.ToString();
                txtContactTitle.Text = row.Cells["ContactTitle"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtRegion.Text = row.Cells["Region"].Value.ToString();
                txtCodePostal.Text = row.Cells["PostalCode"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txt_Fax.Text = row.Cells["Fax"].Value.ToString();

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IngresarCustomer();
            Limpiartxt();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActuCustomer();
            Limpiartxt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarCustomers();
            Limpiartxt();
        }

        private void btnLimpiartxts_Click(object sender, EventArgs e)
        {
            Limpiartxt();
        }

        private void bttonsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Aqui necesita una codigo para que el panel se pueda mover
            // si podes busca un tuco de codigo que permita moverlo ʕ•́ᴥ•̀ʔっ♡


            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
            // este no deja moverlo
            // no es necesario duh
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
