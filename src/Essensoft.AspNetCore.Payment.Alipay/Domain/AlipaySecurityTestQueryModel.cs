using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityTestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityTestQueryModel : AlipayObject
    {
        /// <summary>
        /// 纬度1231
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
