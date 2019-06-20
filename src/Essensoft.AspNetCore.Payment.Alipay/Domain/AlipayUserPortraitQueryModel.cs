using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPortraitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPortraitQueryModel : AlipayObject
    {
        /// <summary>
        /// 1688端传递havanaId的列表过来，单次传递不超过2个
        /// </summary>
        [JsonProperty("havana_id")]
        public List<string> HavanaId { get; set; }
    }
}
