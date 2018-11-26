using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告投放出去的优惠信息
        /// </summary>
        [JsonProperty("discount")]
        [XmlElement("discount")]
        public DiscountInfo Discount { get; set; }
    }
}
