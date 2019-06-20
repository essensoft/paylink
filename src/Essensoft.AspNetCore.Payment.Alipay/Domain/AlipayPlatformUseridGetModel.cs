using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPlatformUseridGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPlatformUseridGetModel : AlipayObject
    {
        /// <summary>
        /// openId的列表
        /// </summary>
        [JsonProperty("open_ids")]
        public List<string> OpenIds { get; set; }
    }
}
