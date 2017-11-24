using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataMemberReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询成功时返回json格式数据
        /// </summary>
        [JsonProperty("report_data")]
        public string ReportData { get; set; }
    }
}
