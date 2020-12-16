using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverlevelQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverlevelQueryModel : AlipayObject
    {
        /// <summary>
        /// 固定值“JUDI”
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 司机姓名
        /// </summary>
        [JsonPropertyName("driver_name")]
        public string DriverName { get; set; }

        /// <summary>
        /// 司机手机号
        /// </summary>
        [JsonPropertyName("driver_phone")]
        public string DriverPhone { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }
    }
}
