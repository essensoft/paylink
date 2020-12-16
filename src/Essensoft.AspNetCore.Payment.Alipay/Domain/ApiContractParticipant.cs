using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApiContractParticipant Data Structure.
    /// </summary>
    public class ApiContractParticipant : AlipayObject
    {
        /// <summary>
        /// 业务主体id，比如淘宝id
        /// </summary>
        [JsonPropertyName("biz_principal_id")]
        public string BizPrincipalId { get; set; }

        /// <summary>
        /// 业务主体类型
        /// </summary>
        [JsonPropertyName("biz_principal_type")]
        public string BizPrincipalType { get; set; }

        /// <summary>
        /// offer、acceptor
        /// </summary>
        [JsonPropertyName("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 主体id，一般是user_id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 主体类型B/C
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }
    }
}
