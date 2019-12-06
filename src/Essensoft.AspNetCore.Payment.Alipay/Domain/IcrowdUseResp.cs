using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IcrowdUseResp Data Structure.
    /// </summary>
    public class IcrowdUseResp : AlipayObject
    {
        /// <summary>
        /// 方法ID
        /// </summary>
        [JsonPropertyName("method_id")]
        public string MethodId { get; set; }

        /// <summary>
        /// 方法返回结果
        /// </summary>
        [JsonPropertyName("ret_val")]
        public string RetVal { get; set; }
    }
}
