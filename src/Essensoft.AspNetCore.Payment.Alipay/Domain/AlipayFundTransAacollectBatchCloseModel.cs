using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCloseModel Data Structure.
    /// </summary>
    public class AlipayFundTransAacollectBatchCloseModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 创建批次返回 的token
        /// </summary>
        [JsonPropertyName("batch_token")]
        public string BatchToken { get; set; }

        /// <summary>
        /// 当前支付宝用户id
        /// </summary>
        [JsonPropertyName("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
