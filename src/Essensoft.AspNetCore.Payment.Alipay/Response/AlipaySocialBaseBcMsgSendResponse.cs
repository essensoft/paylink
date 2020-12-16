using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseBcMsgSendResponse.
    /// </summary>
    public class AlipaySocialBaseBcMsgSendResponse : AlipayResponse
    {
        /// <summary>
        /// 业务错误码，在业务失败的情况下返回
        /// </summary>
        [JsonPropertyName("sub_code")]
        public new string SubCode { get; set; }

        /// <summary>
        /// 业务错误描述，在业务失败的情况下返回
        /// </summary>
        [JsonPropertyName("sub_msg")]
        public new string SubMsg { get; set; }
    }
}
