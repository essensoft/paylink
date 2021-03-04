using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotNetflowInfoQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotNetflowInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备的sn/imei/bizTid等信息
        /// </summary>
        [JsonPropertyName("device_tag")]
        public string DeviceTag { get; set; }
    }
}
