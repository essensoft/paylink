using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeskAreaEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DeskAreaEntity : AlipayObject
    {
        /// <summary>
        /// 区域Id（新增时无需设值）
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 餐区排序
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }
    }
}
