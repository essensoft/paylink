using System;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 退款订单查询
    /// </summary>
    public class LianLianPayRefundQueryRequest : ILianLianPayRequest<LianLianPayRefundQueryResponse>
    {
        /// <summary>
        /// 商户退款流水号。
        /// NoRefund + DtRefund 或 OidRefundno + DtRefund这两个组合中选一组传入。
        /// </summary>
        public string NoRefund { get; set; }

        /// <summary>
        /// 商户退款时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准。
        /// 如 20180130161010。NoRefund + DtRefund 或 OidRefundno + DtRefund这两个组合中选一组传入。
        /// </summary>
        public string DtRefund { get; set; }

        /// <summary>
        /// 连连退款流水号。
        /// 全局唯一。
        /// 如： 2017030400001010。NoRefund + DtRefund 或 OidRefundno + DtRefund这两个组合中选一组传入。
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
                { "oid_refundno", OidRefundNo }
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            throw new NotImplementedException();
        }

        public void SetApiVersion(string apiVersion)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
