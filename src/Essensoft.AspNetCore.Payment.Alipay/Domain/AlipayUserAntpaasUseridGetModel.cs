using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasUseridGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasUseridGetModel : AlipayObject
    {
        /// <summary>
        /// 账户登录号，邮箱或者手机号
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }
    }
}
