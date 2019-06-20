using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SortDeskParam Data Structure.
    /// </summary>
    [Serializable]
    public class SortDeskParam : AlipayObject
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [JsonProperty("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌位ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [JsonProperty("sort")]
        public long Sort { get; set; }
    }
}
