using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAbntaskBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAbntaskBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 结束时间，yyyy-MM-dd HH:mm:ss格式字符串，不传默认为当前时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 当前页码，不传默认为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据量，正整数，不传默认为1000，超过1000也认定为1000
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间，yyyy-MM-dd HH:mm:ss格式字符串，不传默认为end_time往前推30天
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
