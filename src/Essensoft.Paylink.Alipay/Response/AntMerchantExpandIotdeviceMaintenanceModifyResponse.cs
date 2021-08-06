using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceMaintenanceModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceMaintenanceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理订单号
        /// </summary>
        [JsonPropertyName("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
