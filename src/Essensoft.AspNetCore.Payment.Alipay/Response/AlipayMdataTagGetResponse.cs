using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMdataTagGetResponse.
    /// </summary>
    public class AlipayMdataTagGetResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的标签值, JSON字符串
        /// </summary>
        [JsonPropertyName("tag_values")]
        public string TagValues { get; set; }
    }
}
