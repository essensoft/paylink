using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderdeviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyOrderdeviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件申请单号
        /// </summary>
        [JsonProperty("apply_order_id")]
        public string ApplyOrderId { get; set; }
    }
}
