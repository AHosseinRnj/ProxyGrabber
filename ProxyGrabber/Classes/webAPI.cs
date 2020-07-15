using System.Net;

namespace ProxyGrabber.Classes
{
    class webAPI
    {
        WebClient Client = new WebClient();
        private string timeout;
        private string proxytype;
        private string country;
        private string anonymity;
        private string ssl;

        public webAPI(string timeout = "10000", string proxytype = "all", string country = "all", string anonymity = "all", string ssl = "all")
        {
            setParameters(timeout, proxytype, country, anonymity, ssl);
        }

        public void setParameters(string timeout, string proxytype, string country, string anonymity, string ssl)
        {
            setTimeout(timeout);
            setProxyType(proxytype);
            setCountry(country);
            setAnonymity(anonymity);
            setSSL(ssl);
        }

        public void setTimeout(string timeout)
        {
            this.timeout = timeout;
        }

        public void setProxyType(string proxytype)
        {
            this.proxytype = proxytype;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        public void setAnonymity(string anonymity)
        {
            this.anonymity = anonymity;
        }

        public void setSSL(string ssl)
        {
            this.ssl = ssl;
        }

        public string lastUpdated()
        {
            if (proxytype == "all")
                return "Select Proxy Type";
            else
                return Client.DownloadString($"https://api.proxyscrape.com/?request=lastupdated&proxytype={proxytype}");
        }

        public string amountProxies()
        {
            return Client.DownloadString($"https://api.proxyscrape.com/?request=amountproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}");
        }

        public void Download(string path)
        {
            Client.DownloadFile($"https://api.proxyscrape.com?request=getproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}", path);
        }

        public void Dispose()
        {
            Client = null;
            timeout = string.Empty;
            proxytype = string.Empty;
            country = string.Empty;
            anonymity = string.Empty;
            ssl = string.Empty;
        }
    }
}
