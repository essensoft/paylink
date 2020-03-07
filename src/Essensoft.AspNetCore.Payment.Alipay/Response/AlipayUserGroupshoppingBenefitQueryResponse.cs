using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserGroupshoppingBenefitQueryResponse.
    /// </summary>
    public class AlipayUserGroupshoppingBenefitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 拼团支付宝权益透出金额
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 该用户是否有权益
        /// </summary>
        [JsonPropertyName("have_benefit")]
        public bool HaveBenefit { get; set; }

        /// <summary>
        /// 查询权益的图标地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 查询权益的跳转地址
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// 发放权益原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 查询权益的副标题
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 查询权益的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
