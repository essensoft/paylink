using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncUserinvoiceinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncUserinvoiceinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 开票pid/mid/ou，唯一标识商户信息/集团用户信息的ID
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }
}
