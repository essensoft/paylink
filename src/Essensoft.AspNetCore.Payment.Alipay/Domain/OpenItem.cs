using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenItem Data Structure.
    /// </summary>
    public class OpenItem : AlipayObject
    {
        /// <summary>
        /// 单品编号
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 单品检测状态  0，未检测  1，未通过  2，已通过
        /// </summary>
        [JsonPropertyName("item_status")]
        public string ItemStatus { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
