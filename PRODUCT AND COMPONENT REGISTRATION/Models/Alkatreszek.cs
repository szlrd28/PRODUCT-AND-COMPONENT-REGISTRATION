using Microsoft.AspNetCore.Mvc;
using Keszprojekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Keszprojekt.Models
{
    public class Alkatreszek
    {

        public int AlkatreszekId { get; set; }
        

        public string Megnevezes { get; set; }


        public int SulyGr { get; set; }

        public int Ar { get; set; }


        public Alkatreszek()
        {

        }
       /* public virtual ICollection<AKapcsolas> KapcsolatTablak { get; set; }*/
    }
}
