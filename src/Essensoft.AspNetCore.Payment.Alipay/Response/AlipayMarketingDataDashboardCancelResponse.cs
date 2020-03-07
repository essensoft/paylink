using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataDashboardCancelResponse.
    /// </summary>
    public class AlipayMarketingDataDashboardCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 取消授权失败仪表盘列表
        /// </summary>
        [JsonPropertyName("dashboard_fail_list")]
        public List<string> DashboardFailList { get; set; }

        /// <summary>
        /// 取消仪表盘授权结果
        /// </summary>
        [JsonPropertyName("status")]
        public bool Status { get; set; }
    }
}
