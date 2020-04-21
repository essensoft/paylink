using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarDataExternalQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarDataExternalQueryModel : AlipayObject
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
        public bool IsTransferUid { get; set; }

        /// <summary>
        /// operate_type
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// query_condition
        /// </summary>
        [JsonPropertyName("query_condition")]
        public string QueryCondition { get; set; }
    }
}
