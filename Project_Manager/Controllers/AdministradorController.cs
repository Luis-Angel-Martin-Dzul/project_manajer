﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Manager.Services.BO;
using Project_Manager.Services.Services;

namespace Project_Manager.Controllers
{
    public class AdministradorController : Controller
    {
        TblAdministradorCTRL Administrador = new TblAdministradorCTRL();
        TblCuentaCTRL Login = new TblCuentaCTRL();

        // GET: Administrador
        public ActionResult Ver()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        #region Metodos
        public int New()
        {
            string nombre = Request.Form.Get("nombre");
            string apellidop = Request.Form.Get("apellidop");
            string apellidom = Request.Form.Get("apellidom");
            string correo = Request.Form.Get("correo");
            string contraseña = Request.Form.Get("contraseña");
            string usuario = Request.Form.Get("usuario");

            TblAdministradorBO data = new TblAdministradorBO();
            TblCuentaBO login = new TblCuentaBO();

            data.NombreAdmin = nombre;
            data.ApellidoPAdmin = apellidop;
            data.ApellidoMAdmin = apellidom;

            data.CorreoAdmin = correo;
            data.ContraAdmin = contraseña;
            data.FKUsuario = usuario;
            data.FKRol = "Administrador";

            login.Correo = correo;
            login.Contra = contraseña;
            login.Usuario = usuario;
            login.Rol = "Administrador";
            login.Estatus = 0;


            try
            {
                int res = 0;
                res = Login.Alta(login);
                res = 0;
                res = Administrador.Alta(data);
                return res;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        #endregion
    }
}