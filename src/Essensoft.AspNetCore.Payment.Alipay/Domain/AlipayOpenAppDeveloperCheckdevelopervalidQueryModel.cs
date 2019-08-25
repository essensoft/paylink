using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppDeveloperCheckdevelopervalidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppDeveloperCheckdevelopervalidQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }
    }
}
