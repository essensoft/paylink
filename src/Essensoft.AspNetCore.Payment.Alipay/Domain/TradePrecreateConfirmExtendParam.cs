using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmExtendParam Data Structure.
    /// </summary>
    [Serializable]
    public class TradePrecreateConfirmExtendParam : AlipayObject
    {
        /// <summary>
        /// 发码站点
        /// </summary>
        [JsonProperty("precreate_code_from")]
        public string PrecreateCodeFrom { get; set; }
    }
}
