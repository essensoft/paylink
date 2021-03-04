using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessItemTicketSyncModel Data Structure.
    /// </summary>
    public class AlipayBusinessItemTicketSyncModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 表示景区的id
        /// </summary>
        [JsonPropertyName("outer_scenic_id")]
        public string OuterScenicId { get; set; }

        /// <summary>
        /// 门票商品id
        /// </summary>
        [JsonPropertyName("outer_ticket_id")]
        public string OuterTicketId { get; set; }

        /// <summary>
        /// 商户userId
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [JsonPropertyName("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 景区小程序id
        /// </summary>
        [JsonPropertyName("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [JsonPropertyName("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 0：无效 1：有效
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 商品在支付宝内的id
        /// </summary>
        [JsonPropertyName("ticket_goods_id")]
        public string TicketGoodsId { get; set; }

        /// <summary>
        /// 支付宝小程序的商品页面链接
        /// </summary>
        [JsonPropertyName("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonPropertyName("ticket_modified_time")]
        public string TicketModifiedTime { get; set; }

        /// <summary>
        /// 门票规格列表
        /// </summary>
        [JsonPropertyName("ticket_specs")]
        public List<string> TicketSpecs { get; set; }

        /// <summary>
        /// 门票类型 NORMAL("NORMAL","普通"), GROUP("GROUP","套票"), PERIOD("PERIOD","时段票"), REGION("REGION","区域票")
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 更新信息
        /// </summary>
        [JsonPropertyName("update_msg")]
        public string UpdateMsg { get; set; }
    }
}
