using System.Net;

namespace ProxyGrabber.Classes
{
    class webAPI
    {
        string timeout;
        string proxytype;
        string country;
        string anonymity;
        string ssl;
        public webAPI(string timeout, string proxytype, string country, string anonymity, string ssl)
        {
            this.timeout = timeout;
            this.proxytype = proxytype;
            this.country = country;
            this.anonymity = anonymity;
            this.ssl = ssl;
        }

        WebClient Client = new WebClient();

        public string Lastupdated()
        {
            if (proxytype == "all")
                return "Select Proxy Type";
            else
                return Client.DownloadString($"https://api.proxyscrape.com/?request=lastupdated&proxytype={proxytype}");
        }

        public string AmountProxies()
        {
            return Client.DownloadString($"https://api.proxyscrape.com/?request=amountproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}");
        }

        public void Download(string path)
        {
            Client.DownloadFile($"https://api.proxyscrape.com?request=getproxies&proxytype={proxytype}&timeout={timeout}&country={country}&anonymity={anonymity}&ssl={ssl}", path);
        }
    }
}
