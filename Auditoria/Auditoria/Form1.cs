using Auditoria.Model;
using Auditoria.Security;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auditoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DatosBd datos = new DatosBd();
            if (string.IsNullOrEmpty(this.Host.Text.Trim()))
            {
                this.Respuesta.Text = "EL campo Host no puede estar vacio";
                return;
            }
            else
            {
                datos.Host = this.Host.Text;
            }

            if (string.IsNullOrEmpty(this.Port.Text))
            {
                this.Respuesta.Text = "EL campo puerto  no puede ser nulo";
                return;
            }
            else 
            {
                try
                {
                    datos.Port = Convert.ToInt32(this.Port.Text); //conversion cadena a int
                }
                catch (Exception)
                {

                    this.Respuesta.Text = "El puerto ingresado es incorrecto";
                    return;
                }
                
            }

            if (string.IsNullOrEmpty(this.User.Text.Trim()))
            {
                this.Respuesta.Text = "EL campo usuario  no puede estar vacio";
                return;
            }
            else
            {
                datos.User = this.User.Text;
            }

            if (string.IsNullOrEmpty(this.Password.Text.Trim()))
            {
                this.Respuesta.Text = "EL Password  no puede estar vacio";
                return;
            }
            else
            {
                datos.Password = this.Password.Text;
            }
           

            try
            {
                Conexion cn = new Conexion();
                var prueba = cn.oracle(datos.Host, datos.User, datos.Password);
                prueba.Open();
                this.Respuesta.Text = "Conexion Establecida";// se establece conexion
            }
            catch (OracleException ex)
            {
                this.Respuesta.Text = ex.Message;// sino conecta  aparece error 
                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
