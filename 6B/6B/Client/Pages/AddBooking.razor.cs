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
using Domain.Entities;
using Blazored.FluentValidation;
using static System.Net.WebRequestMethods;
using System.Text.Json;
using System.Text;

namespace Client.Pages
{
    public partial class AddBooking
    {
        private Booking NewBooking = new Booking();

        private EditContext? editContext;
        private FluentValidationValidator? _fluentValidationValidator;

        private string message = "";


        protected override async Task OnInitializedAsync()
        {
            editContext = new(NewBooking);


        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {

            if (firstRender)
            {



            }




        }

        private bool isFormValid()
        {
            return _fluentValidationValidator.Validate(options => options.IncludeAllRuleSets());
        }


        private async Task Submit()
        {
            // valdiate form
            // if valid then post to the server
            // catch errors using serilog so we have a record of anything thats gone wrong


            if (isFormValid())
            {

                // show progress bar - find component for this requirement


                var request = new HttpRequestMessage(HttpMethod.Post, "Bookings/AddBooking");

                // set request body
                request.Content = new StringContent(JsonSerializer.Serialize(NewBooking), Encoding.UTF8, "application/json");

                HttpResponseMessage response =  await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    message = "Successfully sent booking";
                    NewBooking = new Booking();
                    // show success message 
                    // reset form
                }
                else
                {
                    message = "Error processing your request. Please try again";

                    // show error message and log it
                }
            }

        }

    }
}