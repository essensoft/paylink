using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppBoyiBoyiCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppBoyiBoyiCreateModel : AlipayObject
    {
        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("com")]
        public GavintestNewLeveaOne Com { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("desd")]
        public GavinTestnew Desd { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("desdmm")]
        public string Desdmm { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("header")]
        public string Header { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("med")]
        public string Med { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}
