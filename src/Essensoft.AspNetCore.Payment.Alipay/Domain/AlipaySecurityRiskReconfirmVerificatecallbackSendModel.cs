using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmVerificatecallbackSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskReconfirmVerificatecallbackSendModel : AlipayObject
    {
        /// <summary>
        /// 账号名
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// 接入的应用编号
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 风险识别流水id，为风险识别的标识，不敏感，无需脱敏
        /// </summary>
        [JsonPropertyName("identify_id")]
        public string IdentifyId { get; set; }

        /// <summary>
        /// 核身方式
        /// </summary>
        [JsonPropertyName("reauth_type")]
        public string ReauthType { get; set; }

        /// <summary>
        /// 核身结果
        /// </summary>
        [JsonPropertyName("reconfirm_result")]
        public bool ReconfirmResult { get; set; }

        /// <summary>
        /// 场景对应的编号
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 设备指纹id
        /// </summary>
        [JsonPropertyName("um_id")]
        public string UmId { get; set; }

        /// <summary>
        /// 采集设备指纹对应的token
        /// </summary>
        [JsonPropertyName("um_id_token")]
        public string UmIdToken { get; set; }

        /// <summary>
        /// 会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
