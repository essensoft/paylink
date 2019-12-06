using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignUserAssetQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignUserAssetQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数目(最大查询50)
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询范围:用户所有资产(USER_ALL_ASSET)，用户指定商户可用资产(USER_MERCHANT_ASSET),用户指定门店可用资产（USER_SHOP_ASSET）;指定USER_SHOP_ASSET必须传递shopid
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 门店id，如果查询范围是门店，门店id不能为空
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
