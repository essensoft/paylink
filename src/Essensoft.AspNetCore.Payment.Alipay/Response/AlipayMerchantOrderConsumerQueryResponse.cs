using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderConsumerQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderConsumerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息  若订单号或业务号存在，则返回
        /// </summary>
        [JsonProperty("order_info")]
        public AlipayOrderDataOpenapiResultInfo OrderInfo { get; set; }
    }
}
