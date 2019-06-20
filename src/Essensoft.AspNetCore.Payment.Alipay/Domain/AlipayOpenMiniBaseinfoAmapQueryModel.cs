using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniBaseinfoAmapQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniBaseinfoAmapQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序应用id
        /// </summary>
        [JsonProperty("appid")]
        public string Appid { get; set; }
    }
}
