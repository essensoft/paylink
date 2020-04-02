using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopOrderConfigInfo Data Structure.
    /// </summary>
    public class ShopOrderConfigInfo : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 店铺营业状态：  可枚举：  (1)OPEN 营业  (2)CLOSE 休息
        /// </summary>
        [JsonPropertyName("order_entry_status")]
        public string OrderEntryStatus { get; set; }

        /// <summary>
        /// 点餐一般营业营业时间配置
        /// </summary>
        [JsonPropertyName("order_normal_business_time")]
        public List<NormalBusinessTimeRule> OrderNormalBusinessTime { get; set; }

        /// <summary>
        /// 点餐特殊营业时间规则配置
        /// </summary>
        [JsonPropertyName("order_special_business_time")]
        public List<SpecialBusinessTimeRule> OrderSpecialBusinessTime { get; set; }

        /// <summary>
        /// OPEN表示打开点餐服务 CLOSED表示关闭点餐服务
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
