using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SistemaVeterinaria.Models;
using SistemaVeterinaria.Views.Auxiliar;
using System.Web.Mvc;

namespace SistemaVeterinaria.Controllers
{
    public class DueñoController : Controller
    {
        // GET: Dueño
        public ActionResult Index()
        {
            return View();
        }

        private ModeloDueño mDueño;
        private string Mensaje;

        //Constructor

        public DueñoController()
        {
            this.mDueño = new ModeloDueño();
        }

        public string mensaje { get => Mensaje; }

        //Agregar un dueño

        public void registrarDueño(FrmDueño view)
        {
            string Nombredueño = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtNombre")).Text;
            string Numerodui = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtDUI")).Text;
            string Direccion = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtDireccion")).Text;
            string Edad = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtEdad")).Text;
            string Email = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtEmail")).Text;
            string Numerotelefono = ((TextBox)view.Page.Master.FindControl("contenido").
                FindControl("txtTelefono")).Text;
            DateTime Fechaingreso = DateTime.Now.Date;

            Dueño unDueño = new Dueño(Fechaingreso, Nombredueño, Numerodui, Direccion, Edad, Email, Numerotelefono);

            bool registrado = mDueño.registrarDueño(unDueño);
            if (registrado)
            {
                ((Label)view.Page.Master.FindControl("contenido").
                    FindControl("lblMensaje")).Text = "Dueño Registrado";
                view.estado = true;
            }
            else
            {
                ((Label)view.Page.Master.FindControl("contenido").
                    FindControl("lblMensaje")).Text = "Error al registrar dueño " + mDueño.mensaje;
            }


        }
    }
}