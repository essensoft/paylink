using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GavinTestnew Data Structure.
    /// </summary>
    [Serializable]
    public class GavinTestnew : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonProperty("test")]
        public string Test { get; set; }
    }
}
