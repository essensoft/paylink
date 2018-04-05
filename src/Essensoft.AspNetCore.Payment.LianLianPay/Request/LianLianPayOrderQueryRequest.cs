using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayOrderQueryRequest : ILianLianPayRequest<LianLianPayOrderQueryResponse>
    {
        /// <summary>
        /// 商户唯一订单号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 连连支付单号
        /// </summary>
        public string OidPayBill { get; set; }


        #region ILianLianPayRequest
        private string QueryVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/orderquery.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "oid_paybill", OidPayBill },
                { "query_version", QueryVersion },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return QueryVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            QueryVersion = apiVersion;
        }
        #endregion
    }
}
