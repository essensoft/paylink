using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefuseVo Data Structure.
    /// </summary>
    public class RefuseVo : AlipayObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝信息
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }
    }
}
