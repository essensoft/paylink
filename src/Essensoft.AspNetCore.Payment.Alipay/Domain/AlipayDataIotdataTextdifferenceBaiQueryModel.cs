using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataTextdifferenceBaiQueryModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataTextdifferenceBaiQueryModel : AlipayObject
    {
        /// <summary>
        /// 文档的文本内容。
        /// </summary>
        [JsonPropertyName("text_s")]
        public string TextS { get; set; }

        /// <summary>
        /// 文档文本
        /// </summary>
        [JsonPropertyName("text_t")]
        public string TextT { get; set; }
    }
}
