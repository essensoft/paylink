using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayRefundQueryRequest : ILianLianPayRequest<LianLianPayRefundQueryResponse>
    {
        /// <summary>
        /// 商户退款流水号
        /// 商户系统唯一标识该退款的流水号（支持按商户退款流水号查询）
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间
        /// 格式：YYYYMMDDH24MISS 14 位数字，精确到秒，此字段可以不送，只要商户退款流水号在商户系统中保证唯一根据退款流水查询的时候 必传
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 连连银通退款流水号
        /// 银通退款流水号（也支持按连连银通的退款流水号加退款时间查询）
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
