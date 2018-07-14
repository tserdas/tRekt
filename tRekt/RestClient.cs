using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tRekt
{
    public class RestClient
    {
        private string getResult;

        public string GetResult
        {
            get
            {
                return getResult;
            }
        }

        public void get()
        {
            using (WebClient wc = new WebClient())
            {
                getResult = wc.DownloadString("https://api.coinmarketcap.com/v1/ticker");
            }
        }

    }
}
