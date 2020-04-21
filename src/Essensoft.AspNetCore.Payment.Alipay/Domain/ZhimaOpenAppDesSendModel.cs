using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaOpenAppDesSendModel Data Structure.
    /// </summary>
    public class ZhimaOpenAppDesSendModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("com")]
        public GavintestNewLeveaOne Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("test")]
        public string Test { get; set; }
    }
}
