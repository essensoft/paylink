using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignDetailInfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignDetailInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 营销活动id，配合《店铺优惠查询alipay.offline.market.shop.discount.query 》接口使用，该接口返回camp_list列表中的biz_id则对应该id。
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 适用门店限制返回数量
        /// </summary>
        [JsonPropertyName("shop_limit_count")]
        public long ShopLimitCount { get; set; }
    }
}
