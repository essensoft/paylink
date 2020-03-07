using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotOrderPrintSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotOrderPrintSyncModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一标识，设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 需要打印的订单数据
        /// </summary>
        [JsonPropertyName("print_data")]
        public string PrintData { get; set; }
    }
}
