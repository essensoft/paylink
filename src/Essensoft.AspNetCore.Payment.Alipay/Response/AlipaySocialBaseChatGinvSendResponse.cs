using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseChatGinvSendResponse.
    /// </summary>
    public class AlipaySocialBaseChatGinvSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果提示信息
        /// </summary>
        [JsonPropertyName("result_tip")]
        public string ResultTip { get; set; }
    }
}
