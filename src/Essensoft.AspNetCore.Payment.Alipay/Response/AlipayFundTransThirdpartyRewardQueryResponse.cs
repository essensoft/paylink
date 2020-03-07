using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardQueryResponse.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 打赏金额，单位：人民币分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 打赏未成功时的错误原因
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 打赏时间，毫秒数
        /// </summary>
        [JsonPropertyName("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 被打赏用户支付宝UserId
        /// </summary>
        [JsonPropertyName("receiver_user_id")]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 打赏用户支付宝UserId
        /// </summary>
        [JsonPropertyName("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账单据号
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }
    }
}
