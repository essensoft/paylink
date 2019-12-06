using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoPriceQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoPriceQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询行情的截止日期，必须是格式为yyyyMMdd的日期字符串且日期要大于等于start_date，时间最大跨度为30天，如start_date为20160808，则end_date最大值为20160906
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 基金代码，必填。目前默认填001529，代表余利宝。
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 查询行情的开始日期，必须是格式为yyyyMMdd的日期字符串，如20160808
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }
    }
}
