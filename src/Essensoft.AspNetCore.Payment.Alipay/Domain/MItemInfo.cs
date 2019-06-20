using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MItemInfo : AlipayObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// item_id字段说明类型，目前支持枚举：菜品：DISH，注意：菜品必须为单品菜品信息
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
