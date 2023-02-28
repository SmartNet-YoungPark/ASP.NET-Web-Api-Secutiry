using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Basic_Authentication_Using_Message_Handler_in_Web_API.Models
{
    public class CustomHeaderHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationTask)
        {
            HttpResponseMessage response = await base.SendAsync(request, cancellationTask);
            response.Headers.Add("X-Customer-Header", "This is my custom header");
            return response;
        }
    }
}