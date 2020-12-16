using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSpOperationResultQueryResponse.
    /// </summary>
    public class AlipayOpenSpOperationResultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 被代运营者为间连商户时有值，此时返回绑定的支付宝账号。
        /// </summary>
        [JsonPropertyName("bind_user_id")]
        public string BindUserId { get; set; }

        /// <summary>
        /// 轮询结果。SUCCESS代表成功;PROCESS处理中
        /// </summary>
        [JsonPropertyName("handle_status")]
        public string HandleStatus { get; set; }

        /// <summary>
        /// 被代运营的商户号。
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }
    }
}
