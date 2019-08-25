using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserMaterialQueryModel : AlipayObject
    {
        /// <summary>
        /// 物料id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
