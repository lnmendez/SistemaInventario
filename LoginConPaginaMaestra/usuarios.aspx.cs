﻿using System;
using Biblioteca;

namespace SistemaInventario
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario evento = new usuario();

            if (txtRut.Text == "" || txtNombre.Text == "" || txtApellidoP.Text == "" || txtApellidoM.Text == "" || txtDate.Text == "" || txtClave.Text == "" || txtClave2.Text == "")
            {
                lblError.Text = "Debe Completar los datos Solicitados";
            }
            else if (txtClave.Text == txtClave2.Text)
            {
                if(evento.InsertUser(txtRut.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtClave.Text, txtDate.Text, dpCargo.Text))
                {
                    Response.Write("<script>window.alert('Agregado Correctamente')</script>");
                    gvUsers.DataBind();
                    txtRut.Text = "";
                    txtNombre.Text = "";
                    txtApellidoP.Text = "";
                    txtApellidoM.Text = "";
                    txtClave.Text = "";
                    txtClave2.Text = "";
                } else
                {
                    lblError.Text = "Error Al Ingresar, Intente de nuevo";
                }
            }
            else {                
                lblError.Text = "Las claves no coinciden";

            }

        }


    }
}