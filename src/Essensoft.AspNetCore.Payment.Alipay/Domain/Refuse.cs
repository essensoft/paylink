using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Refuse Data Structure.
    /// </summary>
    public class Refuse : AlipayObject
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
