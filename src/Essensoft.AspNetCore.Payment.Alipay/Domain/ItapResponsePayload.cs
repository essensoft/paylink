using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItapResponsePayload Data Structure.
    /// </summary>
    public class ItapResponsePayload : AlipayObject
    {
        /// <summary>
        /// 是否成功，true/false
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }

        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
