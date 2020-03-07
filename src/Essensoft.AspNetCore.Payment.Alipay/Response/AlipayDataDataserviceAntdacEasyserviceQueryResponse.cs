using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdacEasyserviceQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdacEasyserviceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 方法返回值＋json字符串格式
        /// </summary>
        [JsonPropertyName("ret_val")]
        public string RetVal { get; set; }
    }
}
