using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simuladorcredito.Web.Models;


namespace Simuladorcredito.Web.Controllers
{
    public class CreditoforController : Controller
    {

        //el nombre del controlador se llama Creditofor 
        // GET: Creditofor
        //[HttpGet]
        public ActionResult Index()//va el nombre del parametro o vista que vamos a llamar"Views-index.cshtml"
        {
 // AQUI VA LO QUE RETORNA AL INDEX 
            var creditof = new List<Creditofor>();

            //creditof.Add(new Creditofor{ });

           // ViewBag.ValorPrestamo = "";



        return View(creditof); //este es para cargar el formulario

        }

        //carga el formulario 
        [HttpGet]
        public ActionResult Registro()//va el nombre del parametro o vista que vamos a llamar"Views-index.cshtml"
        {
            return View(); //este es para cargar el formulario

        }

        //Recibe la infromacion o datos 
        [HttpPost]
        public ActionResult Registro(Creditofor creditofor)
        {
            //var nroCuota = creditofor.NroCuota; 
            // var abonoIntereses = creditofor.AbonoIntereses; 
            // var abonoCapital = creditofor.AbonoCapital; 
            //var cuotaMensual = creditofor.CuotaMensual; 
            // var abonoSeguro = creditofor.AbonoSeguro; 
            // var cuotaMensualmasSeguro = creditofor.CuotaMensualmasSeguro; 
            // var saldo = creditofor.Saldo; 


            var valorPrestamo = creditofor.ValorPrestamo; 
            var plazomeses = creditofor.Plazomeses; 
           // var cuotaTasa = creditofor.CuotaTasa; 
            var valorSeguro = creditofor.ValorSeguro;
            
            return View(); 

        }


    }
}