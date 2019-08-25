using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelContentCancelModel : AlipayObject
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("modified_date")]
        public long ModifiedDate { get; set; }
    }
}
