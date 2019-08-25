using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdUserCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 投放账户支付宝PID
        /// </summary>
        [JsonProperty("alipay_pid")]
        public string AlipayPid { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }
    }
}
