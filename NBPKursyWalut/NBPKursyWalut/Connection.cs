using System.Net;

namespace NBPKursyWalut
{
    class Connection
    {
        private const string resultFormat = "?format=xml";
        private string pathTable = string.Empty;

        /// <summary>
        /// Połączenie z serwisem
        /// </summary>
        /// <returns></returns>
        public WebResponse Connect(string p_category, string p_type)
        {
            pathTable = "http://api.nbp.pl/api/exchangerates/" + p_category + "/" +
                 p_type.ToLower() + resultFormat;
            try
            {
                WebRequest request = WebRequest.CreateHttp(pathTable);
                WebResponse response = request.GetResponse();

                return response;
            }
            catch
            {
                return null;
            }
        }
    }
}
