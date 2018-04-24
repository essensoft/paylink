using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayRefundQueryRequest : ILianLianPayRequest<LianLianPayRefundQueryResponse>
    {
        /// <summary>
        /// 商户退款流水号
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 连连银通退款流水号
        /// </summary>
        public string OidRefundNo { get; set; }

        #region ILianLianPayRequest
        public string GetRequestUrl()
        {
            return "https://queryapi.lianlianpay.com/refundquery.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "no_refund", NoRefund },
                { "dt_refund", DtRefund },
                { "oid_refundno", OidRefundNo },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return string.Empty;
        }

        public void SetApiVersion(string apiVersion)
        {
        }
        #endregion
    }
}
