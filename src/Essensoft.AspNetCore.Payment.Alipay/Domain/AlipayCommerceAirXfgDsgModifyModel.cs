using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAirXfgDsgModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceAirXfgDsgModifyModel : AlipayObject
    {
        /// <summary>
        /// 用户年龄
        /// </summary>
        [JsonPropertyName("age")]
        public string Age { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("nam")]
        public string Nam { get; set; }

        /// <summary>
        /// 男
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("xbw")]
        public string Xbw { get; set; }
    }
}
