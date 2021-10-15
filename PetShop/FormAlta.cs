using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormAlta : Form
    {
        Enumerados.ERango rango;
        public FormAlta(Enumerados.ERango ERango)
        {
            this.rango = ERango;
            InitializeComponent();
        }
        private void FormAlta_Load(object sender, EventArgs e)
        {
            if(rango == Enumerados.ERango.cliente)
            {
                this.lblUsuario.Visible = false;
                this.txtUsuario.Visible = false;
                this.lblPassword.Visible = false;
                this.txtPassword.Visible = false;
            }
            else
            {
                this.lblSaldo.Visible = false;
                this.txtSaldo.Visible = false;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rango == Enumerados.ERango.cliente)
            {
                if(double.TryParse(this.txtSaldo.Text, out double saldo))
                {
                    if(Validaciones.EstaPersona(this.txtCuil.Text))
                    {
                        lblError.Visible = true;
                        lblError.Text = "Error cuil utilizado";
                    }
                    else
                    {
                        try
                        {
                            DatosSistema.AltaCliente(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, saldo);
                        }
                        catch (CuilException cuilException)
                        {
                            this.lblError.Visible = true;
                            this.lblError.Text = cuilException.Message;
                        }
                    }
                }
            }
            if(rango == Enumerados.ERango.empleado)
            {
                if (Validaciones.EstaPersona(this.txtCuil.Text))
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = "Error cuil utilizado";
                }
                else
                {
                    try
                    {
                        DatosSistema.AltaEmpleado(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtUsuario.Text, this.txtPassword.Text);
                    }
                    catch(UsuarioInvalidoException usuarioException)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = usuarioException.Message;
                    }
                    catch(CuilException cuilException)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = cuilException.Message;
                    }
                }
            }
            if(rango == Enumerados.ERango.administrador)
            {
                if (Validaciones.EstaPersona(this.txtCuil.Text))
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = "Error cuil utilizado";
                }
                else if(Validaciones.EstaUsuario(this.txtUsuario.Text))
                {
                    this.lblError.Visible = true;
                    this.lblError.Text = "Error usuario utilizado";
                }
                else
                {
                    try
                    {
                        DatosSistema.AltaAdministrador(this.txtNombre.Text, this.txtApellido.Text, this.txtCuil.Text, this.txtUsuario.Text, this.txtPassword.Text);
                    }
                    catch (UsuarioInvalidoException usuarioException)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = usuarioException.Message;
                    }
                    catch (CuilException cuilException)
                    {
                        this.lblError.Visible = true;
                        this.lblError.Text = cuilException.Message;
                    }
                }
            }
        }       
    }
}
