using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineProviderEquipmentAuthRemoveModel Data Structure.
    /// </summary>
    public class AlipayOfflineProviderEquipmentAuthRemoveModel : AlipayObject
    {
        /// <summary>
        /// 机具编号
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 机具类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 扩展信息，传json格式的字符串，包含auth_alipay_card_no =授权的商户支付宝卡号
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具厂商PID
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }
    }
}
