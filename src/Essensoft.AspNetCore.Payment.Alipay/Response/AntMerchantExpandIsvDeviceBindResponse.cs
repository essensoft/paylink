using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceBindResponse.
    /// </summary>
    public class AntMerchantExpandIsvDeviceBindResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
