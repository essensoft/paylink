using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdEventActionModifyModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdEventActionModifyModel : AlipayObject
    {
        /// <summary>
        /// 返回描述
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 调用风洞唯一标识
        /// </summary>
        [JsonPropertyName("socplt_key")]
        public string SocpltKey { get; set; }

        /// <summary>
        /// action处置状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
