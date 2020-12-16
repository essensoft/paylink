using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ClaimStrategy Data Structure.
    /// </summary>
    public class ClaimStrategy : AlipayObject
    {
        /// <summary>
        /// 事故类型事故类型: 1:超时赔付 2:取消赔付 3:商家切自配送赔付
        /// </summary>
        [JsonPropertyName("accident_type")]
        public string AccidentType { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 常量:单位(分)
        /// </summary>
        [JsonPropertyName("constant")]
        public long Constant { get; set; }

        /// <summary>
        /// 赔付区间上限值
        /// </summary>
        [JsonPropertyName("end_section")]
        public long EndSection { get; set; }

        /// <summary>
        /// 最大赔付金额
        /// </summary>
        [JsonPropertyName("max_amount")]
        public long MaxAmount { get; set; }

        /// <summary>
        /// 赔付最小金额,单位:分
        /// </summary>
        [JsonPropertyName("min_amount")]
        public long MinAmount { get; set; }

        /// <summary>
        /// 价格赔付比例(小数点后两位)
        /// </summary>
        [JsonPropertyName("price_ratio")]
        public long PriceRatio { get; set; }

        /// <summary>
        /// 起配时间，单位:分钟
        /// </summary>
        [JsonPropertyName("start_compensation_time")]
        public long StartCompensationTime { get; set; }

        /// <summary>
        /// 赔付区间起始值
        /// </summary>
        [JsonPropertyName("start_section")]
        public long StartSection { get; set; }

        /// <summary>
        /// 时间赔付比例:小数点后2位
        /// </summary>
        [JsonPropertyName("time_ratio")]
        public long TimeRatio { get; set; }
    }
}
