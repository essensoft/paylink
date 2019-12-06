using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DashBoardMeta Data Structure.
    /// </summary>
    public class DashBoardMeta : AlipayObject
    {
        /// <summary>
        /// 授权状态，值为true或者false
        /// </summary>
        [JsonPropertyName("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 仪表盘创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 仪表盘ID
        /// </summary>
        [JsonPropertyName("dashboard_id")]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘名称
        /// </summary>
        [JsonPropertyName("dashboard_name")]
        public string DashboardName { get; set; }
    }
}
