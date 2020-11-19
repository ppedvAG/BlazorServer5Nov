using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul03
{
    public class Aufgabe
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Erledigt { get; set; }
        public Boolean IsErledigt { get; set; }
        [NotMapped]
        public Boolean IsEdit { get; set; }
    }
}
