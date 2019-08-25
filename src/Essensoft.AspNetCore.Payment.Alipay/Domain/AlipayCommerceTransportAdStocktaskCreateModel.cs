using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdStocktaskCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告主id+创建库存查询任务
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 计价方式 + 是否唯一(不需要) + 创建库存查询任务 + 枚举值（1：CPT 时间保量、2：CPP 人次保量）+ 调用方根据业务需要传入
        /// </summary>
        [JsonProperty("charge_type")]
        public long ChargeType { get; set; }

        /// <summary>
        /// 售卖方式；是否唯一（不需要）+ 创建库存查询任务 + 枚举值（0：GD、1：RTB）+  调用方根据业务需求传入
        /// </summary>
        [JsonProperty("sell_mode")]
        public long SellMode { get; set; }

        /// <summary>
        /// 库存量查询条件 + 是否唯一（不需要）+ 创建库存查询任务 + 业务方根据业务需求构造传入
        /// </summary>
        [JsonProperty("stock_query_condition")]
        public StockQueryCondition StockQueryCondition { get; set; }
    }
}
