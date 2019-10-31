using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCheckIqQueryModel : AlipayObject
    {
        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }
}
