using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MallUserVerify Data Structure.
    /// </summary>
    public class MallUserVerify : AlipayObject
    {
        /// <summary>
        /// 核销状态：UNUSE：未核销，USE：已经核销，CLOSE：关闭
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 核销码类型，包括：SCENE_ORDER(场景订单)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户订单核销码
        /// </summary>
        [JsonPropertyName("verify_code")]
        public string VerifyCode { get; set; }
    }
}
