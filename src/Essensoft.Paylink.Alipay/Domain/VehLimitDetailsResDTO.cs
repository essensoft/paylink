using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VehLimitDetailsResDTO Data Structure.
    /// </summary>
    public class VehLimitDetailsResDTO : AlipayObject
    {
        /// <summary>
        /// 服务商编码
        /// </summary>
        [JsonPropertyName("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 支付宝lbs公共组件cityCode
        /// </summary>
        [JsonPropertyName("lbs_city_code")]
        public string LbsCityCode { get; set; }

        /// <summary>
        /// 限行区域
        /// </summary>
        [JsonPropertyName("limit_area")]
        public string LimitArea { get; set; }

        /// <summary>
        /// 规则详情
        /// </summary>
        [JsonPropertyName("limit_rule_detail")]
        public string LimitRuleDetail { get; set; }

        /// <summary>
        /// 限行规则名称
        /// </summary>
        [JsonPropertyName("limit_rule_name")]
        public string LimitRuleName { get; set; }

        /// <summary>
        /// 此规则涉及尾号
        /// </summary>
        [JsonPropertyName("limit_tail_num")]
        public string LimitTailNum { get; set; }

        /// <summary>
        /// 限行时段
        /// </summary>
        [JsonPropertyName("limit_time")]
        public string LimitTime { get; set; }
    }
}
