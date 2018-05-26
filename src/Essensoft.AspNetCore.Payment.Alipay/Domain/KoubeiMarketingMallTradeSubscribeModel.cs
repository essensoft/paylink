using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallTradeSubscribeModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallTradeSubscribeModel : AlipayObject
    {
        /// <summary>
        /// 会员卡模版id
        /// </summary>
        [JsonProperty("card_template_id")]
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
