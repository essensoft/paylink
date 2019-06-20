using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentCodec Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentCodec : AlipayObject
    {
        /// <summary>
        /// 二维码广告内容
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
