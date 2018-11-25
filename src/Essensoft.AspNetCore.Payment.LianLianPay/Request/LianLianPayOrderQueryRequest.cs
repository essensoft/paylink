using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 收款结果查询
    /// </summary>
    public class LianLianPayOrderQueryRequest : ILianLianPayRequest<LianLianPayOrderQueryResponse>
    {
        /// <summary>
        /// 商户订单号。
        /// 为商户系统内对订单的唯一编号，保证唯一。
        /// 连连会根据 NoOrder 创建连连订单号 OidPaybill，如NoOrder已有对应连连订单号 OidPaybill，则将请求视为重复订单请求。
        /// 重复发起订单请求时，请求中的参数信息需与原创单时一致。
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 连连付款单号。
        /// 全局唯一。
        /// 如： 2011030900001098。如NoOrder为空则此项必传。
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
