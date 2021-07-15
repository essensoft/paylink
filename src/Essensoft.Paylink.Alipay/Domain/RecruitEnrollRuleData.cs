using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// RecruitEnrollRuleData Data Structure.
    /// </summary>
    public class RecruitEnrollRuleData : AlipayObject
    {
        /// <summary>
        /// 素材的要求，json字符串，使用时需要把此字符串解析成json对象
        /// </summary>
        [JsonPropertyName("schema")]
        public string Schema { get; set; }
    }
}
