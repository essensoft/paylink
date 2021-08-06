using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InsuranceClauseInfo Data Structure.
    /// </summary>
    public class InsuranceClauseInfo : AlipayObject
    {
        /// <summary>
        /// 附加条款内容
        /// </summary>
        [JsonPropertyName("additional_item")]
        public string AdditionalItem { get; set; }

        /// <summary>
        /// 主险条款代码
        /// </summary>
        [JsonPropertyName("main_item_code")]
        public string MainItemCode { get; set; }

        /// <summary>
        /// 主险条款内容
        /// </summary>
        [JsonPropertyName("main_item_content")]
        public string MainItemContent { get; set; }

        /// <summary>
        /// 特别约定
        /// </summary>
        [JsonPropertyName("special")]
        public string Special { get; set; }
    }
}
