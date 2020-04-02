using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingGoodsModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportParkingGoodsModifyModel : AlipayObject
    {
        /// <summary>
        /// 1^2^3（表示周一、周二、周三）,此时间与商品履约开始、结束时间取交集，如2019-01-01到2019-03-01期间的周一、周二、周三
        /// </summary>
        [JsonPropertyName("arg_date_week")]
        public string ArgDateWeek { get; set; }

        /// <summary>
        /// "商品履约结束时间，此时间属于日范围内结束时间，如果 结束时间小于开始时间，则默认跨天"
        /// </summary>
        [JsonPropertyName("arg_end_time")]
        public string ArgEndTime { get; set; }

        /// <summary>
        /// 商品履约开始结束时间，此时间属于日范围内开始时间
        /// </summary>
        [JsonPropertyName("arg_start_time")]
        public string ArgStartTime { get; set; }

        /// <summary>
        /// 业务参数 json
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 原价，保留小数点后两位
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
        /// 支付宝商品唯一ID
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        [JsonPropertyName("goods_num")]
        public string GoodsNum { get; set; }

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
        /// isv内部产生商品ID(goods_id和out_id不能同时为空)
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
