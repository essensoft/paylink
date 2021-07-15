using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecruitEnrollRule Data Structure.
    /// </summary>
    public class RecruitEnrollRule : AlipayObject
    {
        /// <summary>
        /// 最大数量
        /// </summary>
        [JsonPropertyName("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 最小数量
        /// </summary>
        [JsonPropertyName("min_size")]
        public long MinSize { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonPropertyName("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 规则数据
        /// </summary>
        [JsonPropertyName("rule_data")]
        public RecruitEnrollRuleData RuleData { get; set; }

        /// <summary>
        /// 招商报名时提交的内容类型: 券:VOUCHER; 小程序:MINI_APP; 报名商户:ENROLL_MERCHANT; 素材:MATERIAL;
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
