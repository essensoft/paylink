using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VerifyExtraParams Data Structure.
    /// </summary>
    public class VerifyExtraParams : AlipayObject
    {
        /// <summary>
        /// IdentifierForVendor，在iOS系统中常被用来唯一标识设备
        /// </summary>
        [JsonPropertyName("idfa")]
        public string Idfa { get; set; }

        /// <summary>
        /// 国际移动设备识别码
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 国际移动用户识别码
        /// </summary>
        [JsonPropertyName("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// 匿名设备标识符
        /// </summary>
        [JsonPropertyName("oaid")]
        public string Oaid { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [JsonPropertyName("umid")]
        public string Umid { get; set; }

        /// <summary>
        /// UTDID，APP 级别的设备标识 ID
        /// </summary>
        [JsonPropertyName("utdid")]
        public string Utdid { get; set; }
    }
}
