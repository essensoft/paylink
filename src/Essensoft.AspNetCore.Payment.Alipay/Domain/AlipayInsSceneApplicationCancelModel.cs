using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneApplicationCancelModel : AlipayObject
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonProperty("application_no")]
        public string ApplicationNo { get; set; }
    }
}
