using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul03
{
    public partial class Temp
    {  
        //[Inject]
          ProtectedLocalStorage _ProtectedLocalStorage;

        protected override Task OnInitializedAsync()
        {
          

            
            return base.OnInitializedAsync();
        }
    }
}
