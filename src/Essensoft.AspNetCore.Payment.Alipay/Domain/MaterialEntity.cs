using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaterialEntity Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialEntity : AlipayObject
    {
        /// <summary>
        /// 配料id
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 配料名称
        /// </summary>
        [JsonProperty("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 加价金额
        /// </summary>
        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }
    }
}
