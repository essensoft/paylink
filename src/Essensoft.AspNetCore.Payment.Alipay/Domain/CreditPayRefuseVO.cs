using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayRefuseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPayRefuseVO : AlipayObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝详情
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
