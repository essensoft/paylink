using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertContentShortLink Data Structure.
    /// </summary>
    [Serializable]
    public class KbAdvertContentShortLink : AlipayObject
    {
        /// <summary>
        /// 链接地址
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
