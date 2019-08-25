using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Shop Data Structure.
    /// </summary>
    [Serializable]
    public class Shop : AlipayObject
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 门店类型，只能选择SMID/MID/PID其中一个
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
