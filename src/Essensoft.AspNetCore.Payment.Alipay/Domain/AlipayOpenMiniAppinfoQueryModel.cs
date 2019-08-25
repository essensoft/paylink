using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAppinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAppinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 应用类型（MINIAPP-小程序，LIEFAPP-生活号）
        /// </summary>
        [JsonProperty("open_app_type")]
        public string OpenAppType { get; set; }
    }
}
