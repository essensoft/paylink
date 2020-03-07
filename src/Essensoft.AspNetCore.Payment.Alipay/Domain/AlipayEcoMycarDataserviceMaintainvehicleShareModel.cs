using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AlipayObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [JsonPropertyName("vid")]
        public string Vid { get; set; }
    }
}
