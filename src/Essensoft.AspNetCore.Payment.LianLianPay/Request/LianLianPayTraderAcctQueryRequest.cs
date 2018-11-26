using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 账户余额查询
    /// </summary>
    public class LianLianPayTraderAcctQueryRequest : ILianLianPayRequest<LianLianPayTraderAcctQueryResponse>
    {
        #region ILianLianPayRequest

        private string Version = "1.0";

        public string GetRequestUrl()
        {
            return "https://traderapi.lianlianpay.com/traderAcctQuery.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "api_version", Version }
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return Version;
        }

        public void SetApiVersion(string apiVersion)
        {
            Version = apiVersion;
        }

        #endregion
    }
}
