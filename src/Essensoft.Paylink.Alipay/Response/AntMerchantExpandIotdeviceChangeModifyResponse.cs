using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIotdeviceChangeModifyResponse.
    /// </summary>
    public class AntMerchantExpandIotdeviceChangeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [JsonPropertyName("biz_order_id")]
        public string BizOrderId { get; set; }
    }
}
