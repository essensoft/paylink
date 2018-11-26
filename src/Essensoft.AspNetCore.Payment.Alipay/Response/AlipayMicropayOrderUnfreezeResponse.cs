using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMicropayOrderUnfreezeResponse.
    /// </summary>
    public class AlipayMicropayOrderUnfreezeResponse : AlipayResponse
    {
        /// <summary>
        /// 冻结订单详情结果
        /// </summary>
        [JsonProperty("unfreeze_order_detail")]
        [XmlElement("unfreeze_order_detail")]
        public UnfreezeOrderDetail UnfreezeOrderDetail { get; set; }
    }
}
