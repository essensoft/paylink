using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ContentRiskDetail Data Structure.
    /// </summary>
    public class ContentRiskDetail : AlipayObject
    {
        /// <summary>
        /// 规则编码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 当前规则对应的扩展信息
        /// </summary>
        [JsonPropertyName("ext_properties")]
        public string ExtProperties { get; set; }

        /// <summary>
        /// 当前规则对应的转换后的原始审核素材
        /// </summary>
        [JsonPropertyName("generated_file")]
        public string GeneratedFile { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 规则命中后，提示或者驳回的话术
        /// </summary>
        [JsonPropertyName("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// https://xx.xxx.com/g/hsxone.mms.materialscenter/v/provider/getMaterialsInfo?file_guid=a87b7dc1fbc04d2c97753612fdd4dd08
        /// </summary>
        [JsonPropertyName("origin_file")]
        public string OriginFile { get; set; }

        /// <summary>
        /// 当前规则命中的风险详情信息，譬如风险在图片的坐标、位置信息,坐标对应文字。
        /// </summary>
        [JsonPropertyName("risk_infos")]
        public string RiskInfos { get; set; }

        /// <summary>
        /// 风险等级,枚举值。 高,中,低 三种
        /// </summary>
        [JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 本条规则的审核状态：枚举值，唯一 ROBOT_PASS：机审通过 ROBOT_REVIEW_REJECT：机审驳回 ROBOT_FAIL：机审失败
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 命中文字，如：命中"关键词"文字
        /// </summary>
        [JsonPropertyName("viola_words")]
        public string ViolaWords { get; set; }
    }
}
