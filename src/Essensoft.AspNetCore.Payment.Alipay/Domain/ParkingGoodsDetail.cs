using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ParkingGoodsDetail Data Structure.
    /// </summary>
    public class ParkingGoodsDetail : AlipayObject
    {
        /// <summary>
        /// 1^2^3（表示周一、周二、周三）,此时间与商品履约开始、结束时间取交集，如2019-01-01到2019-03-01期间的周一、周二、周三
        /// </summary>
        [JsonPropertyName("arg_date_week")]
        public string ArgDateWeek { get; set; }

        /// <summary>
        /// "商品有效时间结束时间，此时间属于日范围内结束时间，如果 结束时间小于开始时间，则默认跨天"
        /// </summary>
        [JsonPropertyName("arg_end_time")]
        public string ArgEndTime { get; set; }

        /// <summary>
        /// 商品有效时间开始时间，此时间属于日范围内开始时间
        /// </summary>
        [JsonPropertyName("arg_start_time")]
        public string ArgStartTime { get; set; }

        /// <summary>
        /// 业务参数 json
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 商品可购买结束日期，截止此时间次日0点（针对日租），会按照日期跨度，按照日维度创建多个商品
        /// </summary>
        [JsonPropertyName("buy_end_date")]
        public string BuyEndDate { get; set; }

        /// <summary>
        /// 商品可购买开始日期（针对日租）
        /// </summary>
        [JsonPropertyName("buy_start_date")]
        public string BuyStartDate { get; set; }

        /// <summary>
        /// 20.00
        /// </summary>
        [JsonPropertyName("cost_price")]
        public string CostPrice { get; set; }

        /// <summary>
        /// 总次数(本期暂不支持)
        /// </summary>
        [JsonPropertyName("count_num")]
        public string CountNum { get; set; }

        /// <summary>
        /// 现价，保留小数点后两位
        /// </summary>
        [JsonPropertyName("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 日次数(本期暂不支持)
        /// </summary>
        [JsonPropertyName("date_num")]
        public string DateNum { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 销售结束时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("end_sell_time")]
        public string EndSellTime { get; set; }

        /// <summary>
        /// 支付宝商品ID列表
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("goods_num")]
        public string GoodsNum { get; set; }

        /// <summary>
        /// "租期类型，01 时租(本期暂不支持)，02 日租，03 周租(本期暂 不支持)，04月租(本期暂不支持)"
        /// </summary>
        [JsonPropertyName("goods_rent_type")]
        public string GoodsRentType { get; set; }

        /// <summary>
        /// NOT_EFFECT：下架；EFFECT：上架；PAUSED：已暂停；
        /// </summary>
        [JsonPropertyName("goods_status")]
        public string GoodsStatus { get; set; }

        /// <summary>
        /// 商品类型01-按时，02-按次(本期暂不支持)
        /// </summary>
        [JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 商品关键字
        /// </summary>
        [JsonPropertyName("keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// isv内部产生商品ID
        /// </summary>
        [JsonPropertyName("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 支付宝返回停车场ID
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 上架时间，格式"YYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("put_time")]
        public string PutTime { get; set; }

        /// <summary>
        /// 销售开始时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("start_sell_time")]
        public string StartSellTime { get; set; }
    }
}
