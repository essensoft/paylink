using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SortDeskParam Data Structure.
    /// </summary>
    public class SortDeskParam : AlipayObject
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonPropertyName("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [JsonPropertyName("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌位ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}
