using global::System;
using global::System.Collections.Generic;
using global::System.Linq;
using global::System.Threading.Tasks;
using global::Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using _6B.Client;
using _6B.Client.Shared;
using Domain.Entities;
using Blazored.FluentValidation;

namespace _6B.Client.Pages
{
    public partial class AddBooking
    {
        private Booking NewBooking = new Booking();

        private EditContext? editContext;
        private FluentValidationValidator? _fluentValidationValidator;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            if (firstRender)
            {

                editContext = new (NewBooking);


            }




        }

        private bool isFormValid()
        {
            return _fluentValidationValidator.Validate(options => options.IncludeAllRuleSets());
        }


        private async Task Submit()
        {
            if (isFormValid())
            {

            }

        }

    }
}