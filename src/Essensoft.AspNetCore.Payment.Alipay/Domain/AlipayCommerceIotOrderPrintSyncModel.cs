using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotOrderPrintSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotOrderPrintSyncModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonProperty("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 需要打印的订单数据
        /// </summary>
        [JsonProperty("print_data")]
        public string PrintData { get; set; }
    }
}
