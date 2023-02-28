using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Basic_Authentication_Using_Message_Handler_in_Web_API.Models
{
    public class MessageHandler1 : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken){
            Debug.WriteLine("process request");

            //call the inner handler
            var response = await base.SendAsync(request, cancellationToken);

            Debug.WriteLine("Process response");
            return response;
        }

    }
}