using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AdMaterialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AdMaterialInfo : AlipayObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料地址
        /// </summary>
        [JsonProperty("material_url")]
        public string MaterialUrl { get; set; }
    }
}
