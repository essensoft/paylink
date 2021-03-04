using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainStagecaterelationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainStagecaterelationQueryModel : AlipayObject
    {
        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 子产品码
        /// </summary>
        [JsonPropertyName("sub_product_code")]
        public string SubProductCode { get; set; }
    }
}
