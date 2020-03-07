using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyApplyModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyApplyModel : AlipayObject
    {
        /// <summary>
        /// 待认证银行卡户名
        /// </summary>
        [JsonPropertyName("bank_card_name")]
        public string BankCardName { get; set; }

        /// <summary>
        /// 待认证银行卡号
        /// </summary>
        [JsonPropertyName("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 人行联行号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 成员机构会员ID
        /// </summary>
        [JsonPropertyName("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 手机号码 用于接收打款验证通知短信
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 业务场景编码，如需要由网商分配
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
