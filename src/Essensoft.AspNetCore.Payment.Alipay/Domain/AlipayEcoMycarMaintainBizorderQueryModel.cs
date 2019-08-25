using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainBizorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarMaintainBizorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 车主平台生成的订单号。
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }
    }
}
