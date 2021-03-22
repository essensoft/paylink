using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ScenicTicketInfo Data Structure.
    /// </summary>
    public class ScenicTicketInfo : AlipayObject
    {
        /// <summary>
        /// 自动检票时间
        /// </summary>
        [JsonPropertyName("auto_check_time")]
        public string AutoCheckTime { get; set; }

        /// <summary>
        /// 检票时间
        /// </summary>
        [JsonPropertyName("check_time")]
        public string CheckTime { get; set; }

        /// <summary>
        /// 完结时间
        /// </summary>
        [JsonPropertyName("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 具体不可用的日期
        /// </summary>
        [JsonPropertyName("invalid_dates")]
        public List<string> InvalidDates { get; set; }

        /// <summary>
        /// 表示一周内什么时间不可用。示例中表示周六、周日不可用。
        /// </summary>
        [JsonPropertyName("invalid_day_in_week")]
        public string InvalidDayInWeek { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 门票单价
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 门票状态 INIT("INIT","初始化") TICKET_RUNNING("TICKET_RUNNING",出票中) TICKET_SUCCESS(TICKET_SUCCESS,出票成功) TICKET_FAILURE("TICKET_FAILURE",出票失败) TO_USE("TO_USE",待核销) USED("USED",已核销) CLOSED("CLOSED",已完结) REFUND_RUNNING("REFUND_RUNNING",待退票) REFUND_SUCCESS("REFUND_SUCCESS",已退票) REFUND_FAILURE("REFUND_FAILURE",退票失败)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 票据数量，若一个实例表示一个门票，ticket_count = 1, 若为聚合门票, ticket_count = n;
        /// </summary>
        [JsonPropertyName("ticket_count")]
        public long TicketCount { get; set; }

        /// <summary>
        /// 更新商品信息时候返回的商品id
        /// </summary>
        [JsonPropertyName("ticket_goods_id")]
        public string TicketGoodsId { get; set; }

        /// <summary>
        /// 票据小程序链接
        /// </summary>
        [JsonPropertyName("ticket_link")]
        public string TicketLink { get; set; }

        /// <summary>
        /// 门票名称
        /// </summary>
        [JsonPropertyName("ticket_name")]
        public string TicketName { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [JsonPropertyName("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 门票规格 成人票、儿童票
        /// </summary>
        [JsonPropertyName("ticket_specs")]
        public string TicketSpecs { get; set; }

        /// <summary>
        /// 门票类型 NORMAL("NORMAL","普通"), GROUP("GROUP","套票"), PERIOD("PERIOD","时段票"), REGION("REGION","区域票")
        /// </summary>
        [JsonPropertyName("ticket_type")]
        public string TicketType { get; set; }

        /// <summary>
        /// 使用结束日期
        /// </summary>
        [JsonPropertyName("use_end_date")]
        public string UseEndDate { get; set; }

        /// <summary>
        /// 入园结束时间
        /// </summary>
        [JsonPropertyName("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 使用开始日期
        /// </summary>
        [JsonPropertyName("use_start_date")]
        public string UseStartDate { get; set; }

        /// <summary>
        /// 入园开始时间
        /// </summary>
        [JsonPropertyName("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
