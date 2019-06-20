using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOperateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeNormalpayOperateQueryModel : AlipayObject
    {
        /// <summary>
        /// 创建订单时返回的订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 请求流水号；外部平台在请求支付和打款等操作时传入的流水号
        /// </summary>
        [JsonProperty("request_no")]
        public string RequestNo { get; set; }
    }
}
