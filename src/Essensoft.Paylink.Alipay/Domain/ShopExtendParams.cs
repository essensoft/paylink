using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ShopExtendParams Data Structure.
    /// </summary>
    public class ShopExtendParams : AlipayObject
    {
        /// <summary>
        /// 店铺类目列表。外卖场景下必填，支持回传多个，可用值需要联系支付宝对口BD给出
        /// </summary>
        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 用于外卖场景的配送费原价
        /// </summary>
        [JsonPropertyName("original_delivery_fee")]
        public Amount OriginalDeliveryFee { get; set; }

        /// <summary>
        /// 店铺销量，需要配合sales_volume_period一起使用。表示某一段时间内该店铺的销量
        /// </summary>
        [JsonPropertyName("sales_volume")]
        public long SalesVolume { get; set; }

        /// <summary>
        /// 店铺销量周期。使用枚举值 MONTH/HALF_YEAR/YEAR 分别表示月/半年/年，该字段需要配合sales_volume一起使用
        /// </summary>
        [JsonPropertyName("sales_volume_period")]
        public string SalesVolumePeriod { get; set; }

        /// <summary>
        /// 店铺可视范围，仅支持距离（邮编暂不支持），指的是用户LBS与店铺距离在该范围内，才面向用户展示。外卖场景下，该字段必填，其余场景非必填。单位：米（m）
        /// </summary>
        [JsonPropertyName("visibility")]
        public long Visibility { get; set; }
    }
}
