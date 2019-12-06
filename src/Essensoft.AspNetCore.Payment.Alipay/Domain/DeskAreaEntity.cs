using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeskAreaEntity Data Structure.
    /// </summary>
    public class DeskAreaEntity : AlipayObject
    {
        /// <summary>
        /// 区域Id（新增时无需设值）
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 餐区名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 餐区排序
        /// </summary>
        [JsonPropertyName("sort")]
        public long Sort { get; set; }
    }
}
