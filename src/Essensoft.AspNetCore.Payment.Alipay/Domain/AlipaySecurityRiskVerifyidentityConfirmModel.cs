using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityConfirmModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityConfirmModel : AlipayObject
    {
        /// <summary>
        /// 接入业务方业务唯一性id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 附加业务信息，Json结构
        /// </summary>
        [JsonPropertyName("biz_params")]
        public string BizParams { get; set; }

        /// <summary>
        /// 身份核验场景CODE，商务谈判基础上，由支付宝来分配。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 核身校验token，是一次核身校验服务中唯一性的token
        /// </summary>
        [JsonPropertyName("verify_token")]
        public string VerifyToken { get; set; }
    }
}
