using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MobileDeviceInfo Data Structure.
    /// </summary>
    public class MobileDeviceInfo : AlipayObject
    {
        /// <summary>
        /// 设备IMEI信息
        /// </summary>
        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 设备品牌
        /// </summary>
        [JsonPropertyName("mobile_brand")]
        public string MobileBrand { get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        [JsonPropertyName("mobile_type")]
        public string MobileType { get; set; }
    }
}
