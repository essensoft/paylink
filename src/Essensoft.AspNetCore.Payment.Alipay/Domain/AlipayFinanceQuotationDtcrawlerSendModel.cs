using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationDtcrawlerSendModel Data Structure.
    /// </summary>
    public class AlipayFinanceQuotationDtcrawlerSendModel : AlipayObject
    {
        /// <summary>
        /// 爬虫平台推送数据，为json字符串，bizNo 为推送流水号，taskName为任务名，业务数据包含在bizData中
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
