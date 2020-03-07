using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDpcAlisisOlapprocessorResponse.
    /// </summary>
    public class AlipayDataDpcAlisisOlapprocessorResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理后返回的数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
