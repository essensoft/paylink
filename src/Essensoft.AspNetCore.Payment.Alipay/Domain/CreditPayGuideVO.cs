using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayGuideVO Data Structure.
    /// </summary>
    public class CreditPayGuideVO : AlipayObject
    {
        /// <summary>
        /// json字符串，表示引导信息
        /// </summary>
        [JsonPropertyName("guide_param")]
        public string GuideParam { get; set; }

        /// <summary>
        /// 是否需要引导
        /// </summary>
        [JsonPropertyName("need_guide")]
        public bool NeedGuide { get; set; }
    }
}
