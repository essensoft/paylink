using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialAntforestEnergyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialAntforestEnergyQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
