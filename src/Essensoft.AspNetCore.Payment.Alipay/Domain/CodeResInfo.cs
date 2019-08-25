using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CodeResInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CodeResInfo : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonProperty("code_id")]
        public string CodeId { get; set; }

        /// <summary>
        /// 二维码url地址
        /// </summary>
        [JsonProperty("code_url")]
        public string CodeUrl { get; set; }
    }
}
