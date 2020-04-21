using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalSendModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataExternalSendModel : AlipayObject
    {
        /// <summary>
        /// external_system_name
        /// </summary>
        [JsonPropertyName("external_system_name")]
        public string ExternalSystemName { get; set; }

        /// <summary>
        /// is_transfer_uid
        /// </summary>
        [JsonPropertyName("is_transfer_uid")]
        public string IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// send_data
        /// </summary>
        [JsonPropertyName("send_data")]
        public string SendData { get; set; }
    }
}
