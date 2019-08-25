using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainAftersaleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainAftersaleSyncModel : AlipayObject
    {
        /// <summary>
        /// 车主平台售后编号
        /// </summary>
        [JsonProperty("aftersale_no")]
        public string AftersaleNo { get; set; }

        /// <summary>
        /// 客服拒绝退款原因描述
        /// </summary>
        [JsonProperty("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 1：受理 2：拒绝
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
