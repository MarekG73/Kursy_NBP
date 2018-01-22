using System.Data;
using System.Net;

namespace NBPKursyWalut
{
    class DataManager
    {
        private DataSet xmlDs = null;

        public DataSet SetData(WebResponse p_response)
        {
            xmlDs = new DataSet();
            xmlDs.ReadXml(p_response.GetResponseStream());

            return xmlDs;
        }
    }
}
