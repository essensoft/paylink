using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataMemberReportQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询报表数据的业务日期，精确到天，格式为yyyymmdd，数据按天返回
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }
    }
}
