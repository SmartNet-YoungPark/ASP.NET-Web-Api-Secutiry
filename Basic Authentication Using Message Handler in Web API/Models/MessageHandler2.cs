using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Basic_Authentication_Using_Message_Handler_in_Web_API.Models
{
    public class MessageHandler2 : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //Create the response
            var response = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("*******Hello called! in the messageHandler2 --" +
                "TaskCompletionSource")
            };

            //Note : TaskCompletionSource creates a task that does not contain a delegate
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}