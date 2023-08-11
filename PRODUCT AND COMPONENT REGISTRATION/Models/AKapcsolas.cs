using Microsoft.AspNetCore.Mvc;
using Keszprojekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace Keszprojekt.Models
{
    public class AKapcsolas
    {
        

        public int TermekId { get; set; }

        public int AlkatreszId { get; set; }
        [Range(1, Int32.MaxValue, ErrorMessage = "Minimum 1.")]

        public int Mennyiseg { get; set; }

       /* public virtual Alkatreszek Alkatresz { get; set; }

        public virtual Termekek Termek { get; set; }*/

    }
}
