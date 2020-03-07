using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardApplyResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 授权失败列表
        /// </summary>
        [JsonPropertyName("dashboard_fail_list")]
        public List<string> DashboardFailList { get; set; }

        /// <summary>
        /// 授权状态
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }
    }
}
