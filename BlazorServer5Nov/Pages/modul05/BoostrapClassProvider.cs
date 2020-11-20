using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer5Nov.Pages.modul05
{
    public class BoostrapClassProvider: FieldCssClassProvider
    { 
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
            return isValid ? "is-valid" : "is-invalid";
        }
    }
}
