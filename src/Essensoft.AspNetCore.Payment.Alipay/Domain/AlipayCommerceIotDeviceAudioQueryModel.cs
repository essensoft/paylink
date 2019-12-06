using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
