using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishCreatedishSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCreatedishSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 反查失败的菜品信息
        /// </summary>
        [JsonPropertyName("fail_group_detail_list")]
        public List<KbdishDetailInfo> FailGroupDetailList { get; set; }

        /// <summary>
        /// 是否需要重试
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }

        /// <summary>
        /// 口碑菜品库skuId列表
        /// </summary>
        [JsonPropertyName("sku_id_list")]
        public List<string> SkuIdList { get; set; }
    }
}
