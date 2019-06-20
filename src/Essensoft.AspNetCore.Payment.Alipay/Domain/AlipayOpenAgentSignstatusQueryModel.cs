using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAgentSignstatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAgentSignstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// isv要查询签约状态的商户账号，是支付宝账号pid（2088开头）
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// isv要查询商户签约状态的产品码，产品码是支付宝内部对产品的唯一标识
        /// </summary>
        [JsonProperty("product_codes")]
        public List<string> ProductCodes { get; set; }
    }
}
