using System;
using System.ComponentModel.DataAnnotations;

namespace Simuladorcredito.Web.Models
{
    public class Creditofor
    {

        //public int NroCuota { get; set; }
        //public Double AbonoIntereses { get; set; }
        //public Double AbonoCapital { get; set; }
        // public Double CuotaMensual { get; set; }
        //public Double AbonoSeguro { get; set; }
        // public Double CuotaMensualmasSeguro { get; set; }
        // public Double Saldo { get; set; }

       [Display(Name = "ValorPrestamo")]
        public int ValorPrestamo { get; set; }


        [Display(Name = "Plazomeses")]
        //Required campo requerido 
        [Required(ErrorMessage = "El campo Plazo es requerido.")]
        public Double Plazomeses { get; set; }


        [Display(Name = "ValorSeguro")]
        // public Double CuotaTasa { get; set; }
        public Double ValorSeguro { get; set; }

    }


}