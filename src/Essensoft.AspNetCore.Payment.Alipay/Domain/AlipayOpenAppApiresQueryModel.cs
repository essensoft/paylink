using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppApiresQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppApiresQueryModel : AlipayObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
