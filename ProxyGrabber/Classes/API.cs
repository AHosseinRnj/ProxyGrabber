using System.Net;

namespace ProxyGrabber.Classes
{
    static class API
    {
        public static string TimeOut = string.Empty;
        public static string ProxyType = string.Empty;
        public static string Country = string.Empty;
        public static string Anonymity = string.Empty;
        public static string Ssl = string.Empty;

        public static WebClient WebClient = new WebClient();

        public static string lastUpdated()
        {
            if (ProxyType == "all")
                return "Select Proxy Type !";
            else
                return "Last updated: " + WebClient.DownloadString($"https://api.proxyscrape.com/?request=lastupdated&proxytype={ProxyType}");
        }

        public static string ProxiesCount()
        {
            return "Amount: " + WebClient.DownloadString($"https://api.proxyscrape.com/?request=amountproxies&proxytype={ProxyType}&timeout={TimeOut}&country={Country}&anonymity={Anonymity}&ssl={Ssl}");
        }

        public static void Download(string path)
        {
            WebClient.DownloadFile($"https://api.proxyscrape.com?request=getproxies&proxytype={ProxyType}&timeout={TimeOut}&country={Country}&anonymity={Anonymity}&ssl={Ssl}", path);
        }
    }
}