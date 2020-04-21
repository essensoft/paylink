using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeskEntity Data Structure.
    /// </summary>
    public class DeskEntity : AlipayObject
    {
        /// <summary>
        /// 餐区ID
        /// </summary>
        [JsonPropertyName("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐桌名称
        /// </summary>
        [JsonPropertyName("desk_name")]
        public string DeskName { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [JsonPropertyName("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌台ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 桌位人数
        /// </summary>
        [JsonPropertyName("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 二维码id
        /// </summary>
        [JsonPropertyName("qr_code_id")]
        public string QrCodeId { get; set; }

        /// <summary>
        /// 餐桌二维码关系ID
        /// </summary>
        [JsonPropertyName("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌位排序
        /// </summary>
        [JsonPropertyName("sort_num")]
        public long SortNum { get; set; }
    }
}
