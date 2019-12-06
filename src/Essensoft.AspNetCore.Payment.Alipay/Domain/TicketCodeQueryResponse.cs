using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TicketCodeQueryResponse Data Structure.
    /// </summary>
    public class TicketCodeQueryResponse : AlipayObject
    {
        /// <summary>
        /// 当前可用份数
        /// </summary>
        [JsonPropertyName("available_quantity")]
        public string AvailableQuantity { get; set; }

        /// <summary>
        /// 凭证生效时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }

        /// <summary>
        /// 凭证失效时间 格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("item_goods_ids")]
        public List<string> ItemGoodsIds { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 凭证核销方式
        /// </summary>
        [JsonPropertyName("ticket_display_mode")]
        public string TicketDisplayMode { get; set; }

        /// <summary>
        /// ticket id
        /// </summary>
        [JsonPropertyName("ticket_id")]
        public string TicketId { get; set; }

        /// <summary>
        /// 券状态
        /// </summary>
        [JsonPropertyName("ticket_status")]
        public string TicketStatus { get; set; }

        /// <summary>
        /// 是否次卡
        /// </summary>
        [JsonPropertyName("time_cards")]
        public bool TimeCards { get; set; }

        /// <summary>
        /// 初始份数
        /// </summary>
        [JsonPropertyName("total_quantity")]
        public string TotalQuantity { get; set; }
    }
}
