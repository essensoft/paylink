using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbdeviceDispenserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbdeviceDispenserQueryModel : AlipayObject
    {
        /// <summary>
        /// 取餐柜的唯一设备ID
        /// </summary>
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
    }
}
