using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductBuyLimitRule Data Structure.
    /// </summary>
    public class ProductBuyLimitRule : AlipayObject
    {
        /// <summary>
        /// 购买限制的类型，0-无需关联，1-需要关联，默认无需关联。 名词解释：票券课程类型商品的无需在意本字段，在价格日历预订下，代表是否需要时间段或场地的连场限制。
        /// </summary>
        [JsonPropertyName("can_buy_limit_type")]
        public string CanBuyLimitType { get; set; }

        /// <summary>
        /// 一笔订单下产品最大购买数量，不传默认无限制。
        /// </summary>
        [JsonPropertyName("can_buy_max_count")]
        public long CanBuyMaxCount { get; set; }

        /// <summary>
        /// 一笔订单下产品最小购买数量，不传默认1
        /// </summary>
        [JsonPropertyName("can_buy_min_count")]
        public long CanBuyMinCount { get; set; }

        /// <summary>
        /// 最大选择数，默认无，价格日历产品下代表一笔订单最大可多选择N个分类(场地)，其他产品类型暂无意义
        /// </summary>
        [JsonPropertyName("category_choose_max_count")]
        public long CategoryChooseMaxCount { get; set; }

        /// <summary>
        /// 场馆最小选择数，默认1，价格日历产品下代表一笔订单至少选择可跨几个分类(场地)，其他产品类型暂无意义
        /// </summary>
        [JsonPropertyName("category_choose_min_count")]
        public long CategoryChooseMinCount { get; set; }
    }
}
