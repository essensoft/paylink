using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderUnlimitedQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderUnlimitedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单信息  若订单号或业务号存在，则返回
        /// </summary>
        [JsonPropertyName("order_info")]
        public AlipayOrderDataOpenapiResultInfo OrderInfo { get; set; }
    }
}
