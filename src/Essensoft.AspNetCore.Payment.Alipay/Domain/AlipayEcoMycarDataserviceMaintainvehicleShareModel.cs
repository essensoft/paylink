using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataserviceMaintainvehicleShareModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarDataserviceMaintainvehicleShareModel : AlipayObject
    {
        /// <summary>
        /// 车辆ID
        /// </summary>
        [JsonProperty("vid")]
        public string Vid { get; set; }
    }
}
