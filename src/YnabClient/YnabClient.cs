using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ynab_csharp
{
    class YnabClient : IYnabClient, IDisposable
    {
        private bool _disposedValue = false; // To detect redundant calls

        private HttpClient _httpClient;

        public YnabClient(HttpClient client = null)
        {
            if (client == null)
            {
                _httpClient = new HttpClient();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _httpClient.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
