using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardActivateurlApplyResponse.
    /// </summary>
    public class AlipayMarketingCardActivateurlApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 会员卡领卡链接(使用时需URLDecode解码)。商户获取此链接后可投放到服务窗消息、店铺二维码等。
        /// </summary>
        [JsonProperty("apply_card_url")]
        [XmlElement("apply_card_url")]
        public string ApplyCardUrl { get; set; }
    }
}
