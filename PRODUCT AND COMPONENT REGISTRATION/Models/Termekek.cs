using Microsoft.AspNetCore.Mvc;
using Keszprojekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Keszprojekt.Models
{
    public class Termekek
    {

        public int TermekekId { get; set; }

        public string Megnevezes { get; set; }

        public int SulyGr { get; set; }

        public int Ar { get; set; }

        public Termekek()
        {

        }

       /*public virtual ICollection<AKapcsolas> KapcsolatTablak { get; set; }*/
    }
}
