using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceLocationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceLocationQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }
    }
}
