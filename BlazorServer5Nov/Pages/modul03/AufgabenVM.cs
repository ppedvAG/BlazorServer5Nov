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

        public Action OnTodosChanged;

        public List<Aufgabe> ListeAufgaben { get; set; }
        public void Speichern(Aufgabe a)
        {

            if (a.ID < 1) //NEU 0 wäre neu
            {

                if (ListeAufgaben.Count > 0)
                {
                    var id = ListeAufgaben.Max(x => x.ID);
                    a.ID = id + 1;
                }
                else //Liste komplett leer it 1 INiti
                {
                    a.ID = 1;
                }


                ListeAufgaben.Add(a);
            }
            else //Update
            {
                var _a = ListeAufgaben.Where(x => x.ID == a.ID).FirstOrDefault();
                _a.IsErledigt = a.IsErledigt;
                _a.Text = a.Text;
            }
            OnTodosChanged?.Invoke();
            //var Wert = JsonSerializer.Serialize(ListeAufgaben);

            //JSRuntime.InvokeVoidAsync("localStorage.setItem", "Todos", Wert);


        }
        public async void InitAsync()
        {
            if (ListeAufgaben==null)
            {
     ListeAufgaben = new List<Aufgabe>();

            }
       
            //try
            //{
            //    var res = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "Todos");
            //    ListeAufgaben = JsonSerializer.Deserialize<List<Aufgabe>>(res);

            //}
            //catch (Exception)
            //{


            //}
        }

    }
}
