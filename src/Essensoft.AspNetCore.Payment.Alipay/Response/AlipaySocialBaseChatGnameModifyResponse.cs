using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyResponse.
    /// </summary>
    public class AlipaySocialBaseChatGnameModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [JsonPropertyName("result_modify")]
        public bool ResultModify { get; set; }
    }
}
