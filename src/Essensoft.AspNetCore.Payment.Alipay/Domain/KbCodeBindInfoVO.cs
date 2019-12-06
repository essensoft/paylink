using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbCodeBindInfoVO Data Structure.
    /// </summary>
    public class KbCodeBindInfoVO : AlipayObject
    {
        /// <summary>
        /// 商家餐桌摆放的区域名称（预留字段，暂不使用）
        /// </summary>
        [JsonPropertyName("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 餐桌最大就餐人数（预留字段，暂不使用）
        /// </summary>
        [JsonPropertyName("max_pepole_num")]
        public long MaxPepoleNum { get; set; }

        /// <summary>
        /// 餐桌就餐的最少人数（预留字段，暂不使用）
        /// </summary>
        [JsonPropertyName("min_pepole_num")]
        public string MinPepoleNum { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// table_no对应的中文名称。（预留字段，暂不使用）
        /// </summary>
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }

        /// <summary>
        /// 商家收银系统录入的点菜桌号（生成桌码时，必填）
        /// </summary>
        [JsonPropertyName("table_no")]
        public string TableNo { get; set; }
    }
}
