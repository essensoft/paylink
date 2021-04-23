using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
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
        /// 打款认证结果通知地址
        /// </summary>
        [JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 统一社会信用代码，按场景约定是否必填
        /// </summary>
        [JsonPropertyName("credit_code")]
        public string CreditCode { get; set; }

        /// <summary>
        /// 法定代表人证件号，按场景约定是否必填
        /// </summary>
        [JsonPropertyName("legal_person_cert_no")]
        public string LegalPersonCertNo { get; set; }

        /// <summary>
        /// 法定代表人证件类型，按场景约定是否必填  01 - 身份证号码 02 - 护照 03 - 港澳居民身份证 04 - 台湾同胞回乡证
        /// </summary>
        [JsonPropertyName("legal_person_cert_type")]
        public string LegalPersonCertType { get; set; }

        /// <summary>
        /// 法定代表人姓名，按场景约定是否必填
        /// </summary>
        [JsonPropertyName("legal_person_name")]
        public string LegalPersonName { get; set; }

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
