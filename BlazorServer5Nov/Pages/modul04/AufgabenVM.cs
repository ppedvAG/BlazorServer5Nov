using BlazorServer5Nov.Pages.modul03;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul04
{
    public class AufgabenVM
    {
        AufgabenContext db;
        public AufgabenVM([FromServices] AufgabenContext _db)
        {
            db = _db;

        }

        public Action OnTodosChanged;

        public List<Aufgabe> ListeAufgaben { get; set; }
        public void Neu(Aufgabe a)
        {
            db.Aufgabe.Add(a);
            db.SaveChanges();
            ListeAufgaben.Add(a);
            OnTodosChanged?.Invoke();
        }
        public void Speichern(Aufgabe a)
        {
            var _a = db.Aufgabe.Find(a.ID);
            _a.IsErledigt = a.IsErledigt;
            _a.Text = a.Text;
            db.Aufgabe.Attach(_a);
            db.SaveChanges();

            OnTodosChanged?.Invoke();



        }
        public async void InitAsync()
        {
            if (ListeAufgaben == null)
            {
                ListeAufgaben = db.Aufgabe.ToList();

            }


        }

    }
}
