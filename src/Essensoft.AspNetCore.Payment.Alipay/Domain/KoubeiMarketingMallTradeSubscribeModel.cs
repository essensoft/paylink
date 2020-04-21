using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallTradeSubscribeModel Data Structure.
    /// </summary>
    public class KoubeiMarketingMallTradeSubscribeModel : AlipayObject
    {
        /// <summary>
        /// 会员卡模版id
        /// </summary>
        [JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
