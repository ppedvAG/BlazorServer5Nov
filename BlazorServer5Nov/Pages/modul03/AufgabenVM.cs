using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul03
{
    public class AufgabenVM
    {
        IJSRuntime JSRuntime;
        public AufgabenVM([FromServices] IJSRuntime _JSRuntime)
        {
            JSRuntime = _JSRuntime;
        }
        public List<Aufgabe> ListeAufgaben { get; set; }
        public void Speichern(Aufgabe a)
        {

            if (a.ID < 1) //NEU
            {
                var id = ListeAufgaben.Max(x => x.ID) + 1;
                a.ID = id;  
                
                ListeAufgaben.Add(a);
            }
            else //Update
            {
                var _a = ListeAufgaben.Where(x=>x.ID==a.ID).FirstOrDefault();
                _a.IsErledigt = a.IsErledigt;
                _a.Text = a.Text;
            }
       
            var Wert = JsonSerializer.Serialize(ListeAufgaben);

            JSRuntime.InvokeVoidAsync("localStorage.setItem", "Todos", Wert);


        }
        public async void InitAsync()
        {

            try
            {
                var res = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "Todos");
                ListeAufgaben = JsonSerializer.Deserialize<List<Aufgabe>>(res);
                
            }
            catch (Exception)
            {


            }
        }

    }
}
