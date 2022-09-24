using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
        public Form1()    
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtGuardar_Click(object sender, EventArgs e)
        {
            int ID;
            if (!int.TryParse(TexID.Text, out ID))
            {
                errorProvider1.SetError(TexID, "No ingresó un ID válido");
                TexNombre.Focus();
                return;
            }
            errorProvider1.SetError(TexID, "");

            if (TexNombre.Text == "")
            {
                errorProvider1.SetError(TexNombre, "No ingreso el nombre");
                TexNombre.Focus();
                return;
            }
                errorProvider1.SetError(TexNombre, "");

            double Salario;
            if (!double.TryParse(TexSalario.Text, out Salario))
            {
                errorProvider1.SetError(TexSalario, "No ingresó el salario de forma correcta");
                TexSalario.Focus();
                return;
            }
                errorProvider1.SetError(TexID, "");
    
            if (TexDUI.Text == "")
            {
                errorProvider1.SetError(TexDUI, "No ingreso el DUI");
                TexNombre.Focus();
                return;
            }
                errorProvider1.SetError(TexNombre, "");
            {
                Empleado.Id = Convert.ToInt32(TexID.Text);
                Empleado.Nombre = TexNombre.Text;
                Empleado.Dui = TexDUI.Text;
                LabelRegistro.Text = "¡Registro guardado!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AfP_Click(object sender, EventArgs e)
        {
            TexAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }
        private void ButISSS_Click(object sender, EventArgs e)
        {
            TexIS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }
        private void ButNeto_Click(object sender, EventArgs e)
        {
            TexNeto.Text = Empleado.Neto(Empleado.Salario).ToString();
        }
    }
}
