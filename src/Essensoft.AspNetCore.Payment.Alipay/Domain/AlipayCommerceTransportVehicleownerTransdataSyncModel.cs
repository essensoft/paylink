using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerTransdataSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerTransdataSyncModel : AlipayObject
    {
        /// <summary>
        /// 同步操作类型
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 同步数据
        /// </summary>
        [JsonPropertyName("trans_data")]
        public string TransData { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
