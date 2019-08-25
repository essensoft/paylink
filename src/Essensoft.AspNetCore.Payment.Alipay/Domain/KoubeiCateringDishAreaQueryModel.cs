using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishAreaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishAreaQueryModel : AlipayObject
    {
        /// <summary>
        /// 餐区id
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonProperty("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店id 支付宝的
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 餐台id  根据餐台反查到餐区，再返回全模型
        /// </summary>
        [JsonProperty("tab_id")]
        public string TabId { get; set; }
    }
}
