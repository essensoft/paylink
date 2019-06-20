using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DashBoardMeta Data Structure.
    /// </summary>
    [Serializable]
    public class DashBoardMeta : AlipayObject
    {
        /// <summary>
        /// 授权状态，值为true或者false
        /// </summary>
        [JsonProperty("auth_status")]
        public bool AuthStatus { get; set; }

        /// <summary>
        /// 仪表盘创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 仪表盘ID
        /// </summary>
        [JsonProperty("dashboard_id")]
        public string DashboardId { get; set; }

        /// <summary>
        /// 仪表盘名称
        /// </summary>
        [JsonProperty("dashboard_name")]
        public string DashboardName { get; set; }
    }
}
