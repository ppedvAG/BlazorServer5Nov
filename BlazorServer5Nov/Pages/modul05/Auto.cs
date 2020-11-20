using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul05
{
    public class Auto
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Da muss was rein")]
        [StringLength(5,ErrorMessage ="keine Automarke")]
        public string Marke { get; set; }
        [Required(ErrorMessage = "Da muss was rein")]
        [Range(1950,2030, ErrorMessage ="du umweltsau")]
        public int Baujahr { get; set; }
    }
}
