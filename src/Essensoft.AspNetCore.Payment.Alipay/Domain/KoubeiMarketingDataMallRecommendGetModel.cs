using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMallRecommendGetModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataMallRecommendGetModel : AlipayObject
    {
        /// <summary>
        /// 获取几条数据，最大值传入50，默认值10
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 获取的数据类型:big_item(商圈商品)、small_item(商圈下门店商品)、big_voucher(商圈券)、small_voucher(商圈下门店券)
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 商圈ID
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 店铺类目ID
        /// </summary>
        [JsonPropertyName("shop_category_ids")]
        public List<string> ShopCategoryIds { get; set; }

        /// <summary>
        /// 起始数据下标，默认值0
        /// </summary>
        [JsonPropertyName("start")]
        public long Start { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
