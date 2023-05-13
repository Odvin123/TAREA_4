using Microsoft.EntityFrameworkCore;
using Odvin.Data;
using Odvin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odvin
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (var context = new NorthwindContext())
            {
                var lst = from c in context.Customers
                          orderby c.CompanyName ascending
                          select new
                          {
                              c.CustomerId,
                              c.CompanyName,
                              c.ContactName,
                              c.ContactTitle,
                              c.Address,
                               c.City,
                               c.Region,
                               c.PostalCode,
                               c.Country,
                               c.Phone,
                               c.Fax
                          };
                dgvCustomer.DataSource = lst.ToList();

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            using (var context = new NorthwindContext())
            {
                objCustomer = new Customer();
                objCustomer.CustomerId = txtCustomerID.Text;
                objCustomer.CompanyName = txtNombreCompañia.Text;
                objCustomer.ContactName = txtNombreCliente.Text;
                objCustomer.ContactTitle = txtTituloContacto.Text;
                objCustomer.Address = txtDireccion.Text;
                objCustomer.City = txtCiudad.Text;
                objCustomer.Region = txtRegion.Text;
                objCustomer.PostalCode = txtCodigoPostal.Text;
                objCustomer.Country = txtPais.Text;
                objCustomer.Phone = txtCelular.Text;
                objCustomer.Fax = txtFax.Text;
                context.Customers.Add(objCustomer);
                context.SaveChanges();
                Limpiar();
                MessageBox.Show("Registro Realizado");
                Refrescar();


            }
        }
      

        private void Limpiar()
        {
            txtCustomerID.Text = String.Empty;
            txtNombreCompañia.Text = String.Empty;
            txtNombreCliente.Text = String.Empty;
            txtTituloContacto.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtCiudad.Text = String.Empty;
            txtRegion.Text = String.Empty;
            txtCodigoPostal.Text = String.Empty;
            txtPais.Text = String.Empty;
            txtCelular.Text = String.Empty;
            txtFax.Text = String.Empty;
            id = "";

        }
        private static string id = "";
        Customer? objCustomer = null;

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                if (row.Index == e.RowIndex)
                {
                    id = row.Cells[0].Value.ToString();
                    ObtenerDatos(id);
                }
            }

        }

        private void ObtenerDatos(string key)
        {
            using (var context = new NorthwindContext())
            {
                // buscando el registro para actualizar
                objCustomer = context.Customers.Find(key);

                txtCustomerID.Text = objCustomer?.CustomerId;
                txtNombreCompañia.Text= objCustomer?.CompanyName;
                txtNombreCliente.Text = objCustomer?.ContactName;
                txtTituloContacto.Text = objCustomer.ContactTitle;
                txtDireccion.Text = objCustomer?.Address;
               txtCiudad.Text = objCustomer?.City;
                txtRegion.Text = objCustomer?.Region;
                txtCodigoPostal.Text = objCustomer?.PostalCode;
                txtPais.Text = objCustomer?.Country;
                txtCelular.Text = objCustomer?.Phone;
                txtFax.Text = objCustomer?.Fax;
            }
        }

     
      
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text != string.Empty)            
            {
                using (var context = new NorthwindContext())
                {
                    // buscando el registro 
                    objCustomer = context.Customers.Find(txtCustomerID.Text);

                    objCustomer.CompanyName = txtNombreCompañia.Text;
                    objCustomer.ContactName = txtNombreCliente.Text;
                    objCustomer.ContactTitle = txtTituloContacto.Text;
                    objCustomer.Address = txtDireccion.Text;
                    objCustomer.City = txtCiudad.Text;
                    objCustomer.Region = txtRegion.Text;
                    objCustomer.PostalCode = txtCodigoPostal.Text;
                    objCustomer.Country = txtPais.Text;
                    objCustomer.Phone = txtCelular.Text;
                    objCustomer.Fax = txtFax.Text;
                    context.Entry(objCustomer).State = EntityState.Modified;
                    context.SaveChanges();
                    Limpiar();
                    MessageBox.Show("Registro actualizado");
                    Refrescar();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (id != string.Empty)
            {
                using (var context = new NorthwindContext())
                {
                    Customer ocustomer = context.Customers.Find(id);
                    context.Customers.Remove(ocustomer);
                    context.SaveChanges();
                }
                Limpiar();
                MessageBox.Show("Registro eliminado");
                Refrescar();
            }
        }
    }
}
