using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailChannelBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertDataPromotedetailChannelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道id(不传查所有id)
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 结束时间(精确到天)
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小(分页参数)
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间(精确到天)
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
