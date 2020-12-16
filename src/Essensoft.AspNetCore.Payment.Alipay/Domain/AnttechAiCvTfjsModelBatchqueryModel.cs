using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelBatchqueryModel Data Structure.
    /// </summary>
    public class AnttechAiCvTfjsModelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 模型信息，包含模型code和版本号，单组模型code和版本通过英文分号(:)分隔，多组模型信息之间用英文分号(;)分隔
        /// </summary>
        [JsonPropertyName("model_info")]
        public string ModelInfo { get; set; }
    }
}
