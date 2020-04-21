using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyModifyResponse.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
