using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProfileSnDetail Data Structure.
    /// </summary>
    public class ProfileSnDetail : AlipayObject
    {
        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// sn状态 -1无效，1未使用 。2已使用
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
