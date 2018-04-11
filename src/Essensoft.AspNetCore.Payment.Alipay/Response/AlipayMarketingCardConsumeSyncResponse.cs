using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardConsumeSyncResponse.
    /// </summary>
    public class AlipayMarketingCardConsumeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 外部卡号
        /// </summary>
        [JsonProperty("external_card_no")]
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }
    }
}
