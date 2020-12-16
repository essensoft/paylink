using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandOrderQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请单 id。通过https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.shop.create等接口进件时返回的order_id。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
