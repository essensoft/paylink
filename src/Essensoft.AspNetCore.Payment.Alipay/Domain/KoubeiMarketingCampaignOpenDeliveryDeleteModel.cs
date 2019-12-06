using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignOpenDeliveryDeleteModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignOpenDeliveryDeleteModel : AlipayObject
    {
        /// <summary>
        /// 要删除店铺页投放内容的类型。目前支持的类型有：1. gift_card
        /// </summary>
        [JsonPropertyName("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 商户的PID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 要删除内容投放的门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
