using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Refuse Data Structure.
    /// </summary>
    [Serializable]
    public class Refuse : AlipayObject
    {
        /// <summary>
        /// 拒绝码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 拒绝信息
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
