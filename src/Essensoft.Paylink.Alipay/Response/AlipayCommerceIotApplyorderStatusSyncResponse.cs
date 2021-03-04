using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotApplyorderStatusSyncResponse.
    /// </summary>
    public class AlipayCommerceIotApplyorderStatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 该订单下关联的设备数量
        /// </summary>
        [JsonPropertyName("device_amount")]
        public long DeviceAmount { get; set; }
    }
}
