using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductBuyLimitRule Data Structure.
    /// </summary>
    public class ProductBuyLimitRule : AlipayObject
    {
        /// <summary>
        /// 购买时间限制，商品可下单的时间范围，为“可购买开始时间-可购买截止时间”时间段列表。全天可购买时可以不传值或者传["00:00:00-23:59:59"]；全天不可购买时传值["00:00:00-00:00:00"]。每个时间段内截止时间不能早于开始时间，多个时间段相互不能重合，如果传值错误会导致商品信息无法正常展示而被隐藏。
        /// </summary>
        [JsonPropertyName("buy_time_limit")]
        public List<string> BuyTimeLimit { get; set; }

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

        /// <summary>
        /// （已废弃，无效）可购买截止时间，当前时间大于这个时间用户不能下单。 如果全天可下单，可购买开始和截止时间可以为空或者为00:00:00 - 23:59:59；如果全天不可下单，可购买开始时间(daily_start_time)和可购买截止时间(daily_end_time)均为00:00:00。
        /// </summary>
        [JsonPropertyName("daily_end_time")]
        public string DailyEndTime { get; set; }

        /// <summary>
        /// （已废弃，无效）可购买开始时间，当前时间小于这个时间用户不能下单。 默认00:00:00
        /// </summary>
        [JsonPropertyName("daily_start_time")]
        public string DailyStartTime { get; set; }
    }
}
