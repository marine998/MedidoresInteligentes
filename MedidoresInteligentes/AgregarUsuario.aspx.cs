﻿using MedidorModel;
using MedidorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresInteligentes
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();
        private IUsuarioDAL usuarioDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDDL.DataSource = this.medidorDAL.Obtenermedidor();
                this.medidorDDL.DataTextField = "nombre";
                this.medidorDDL.DataValueField = "id_medidor";
                this.medidorDDL.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            usuario u = new usuario();
            u.nombre = this.nombreTxt.Text.Trim();
            u.rut = this.rutTxt.Text.Trim();
            u.correo = this.correoTxt.Text.Trim();
            u.contraseña = this.contraTxt.Text.Trim();
            u.id_medidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);
            this.usuarioDAL.AgregarUsuario(u);
            Response.Redirect("MostrarUsuario.aspx");
        }
    }
}