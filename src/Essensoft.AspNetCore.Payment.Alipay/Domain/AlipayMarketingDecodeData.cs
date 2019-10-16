using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDecodeData Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDecodeData : AlipayObject
    {
        /// <summary>
        /// 钱包二维码码值
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
