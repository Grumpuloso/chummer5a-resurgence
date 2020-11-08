using System;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using NLog;

namespace ChummerHub.Client.Backend
{
    public class MyMessageHandler : DelegatingHandler
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public MyMessageHandler()
        {
            var httpClientHandler = new HttpClientHandler
            {
                Proxy = WebRequest.DefaultWebProxy,
                // new WebProxy("http://localhost:8888"),
                UseProxy = true,
                Credentials = CredentialCache.DefaultCredentials,
                PreAuthenticate = true,
                CookieContainer = new CookieContainer(),
                UseDefaultCredentials = true
            };
            httpClientHandler.Proxy.Credentials = CredentialCache.DefaultCredentials;

            InnerHandler = httpClientHandler;
        }

        private static int requestCounter;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            int myCounter = ++requestCounter;
            string msg = "Process request " + myCounter + ": " + request.RequestUri;
            Log.Debug<object>(msg);
            try
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                // Call the inner handler.
                request.Headers.TryAddWithoutValidation("ContentType", "application/json");
                var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(true);
                sw.Stop();
                msg = "Process response " + myCounter + " (" + (sw.ElapsedMilliseconds / 1000.0d).ToString(CultureInfo.InvariantCulture) + "): " + response.StatusCode;
                Log.Debug<object>(msg);
                return response;
            }
            catch(Exception e)
            {
                e.Data.Add("request", request.AsFormattedString());
                Log.Error(e);
                throw;
            }
        }
    }
}
