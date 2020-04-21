using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishAreaQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishAreaQueryModel : AlipayObject
    {
        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonPropertyName("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonPropertyName("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id 支付宝的
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 餐台id  根据餐台反查到餐区，再返回全模型
        /// </summary>
        [JsonPropertyName("tab_id")]
        public string TabId { get; set; }
    }
}
