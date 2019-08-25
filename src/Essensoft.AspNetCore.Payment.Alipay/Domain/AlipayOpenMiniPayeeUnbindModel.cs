using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPayeeUnbindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPayeeUnbindModel : AlipayObject
    {
        /// <summary>
        /// 支付宝登陆账号,和pid两者必选其一，小程序如收款pid与小程序PID非同主体，则只支持通过pid解绑
        /// </summary>
        [JsonProperty("logonid")]
        public string Logonid { get; set; }

        /// <summary>
        /// 支付宝账号id,和logonid两者必选其一，小程序如收款pid与小程序PID非同主体，则只支持通过pid解绑
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
