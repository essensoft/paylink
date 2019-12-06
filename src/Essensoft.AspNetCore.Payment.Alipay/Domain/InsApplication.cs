using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsApplication Data Structure.
    /// </summary>
    public class InsApplication : AlipayObject
    {
        /// <summary>
        /// 投保参数 ,每个产品特有的投保参数,如航空险的航班信息;标准json格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 份数
        /// </summary>
        [JsonPropertyName("copies")]
        public long Copies { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("effect_end_time")]
        public string EffectEndTime { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 保险标的
        /// </summary>
        [JsonPropertyName("ins_object")]
        public InsObject InsObject { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonPropertyName("insured")]
        public InsPerson Insured { get; set; }

        /// <summary>
        /// 险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
