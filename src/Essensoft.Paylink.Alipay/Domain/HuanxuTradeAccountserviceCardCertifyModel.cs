using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// HuanxuTradeAccountserviceCardCertifyModel Data Structure.
    /// </summary>
    public class HuanxuTradeAccountserviceCardCertifyModel : AlipayObject
    {
        /// <summary>
        /// 银行卡信息
        /// </summary>
        [JsonPropertyName("bank_info")]
        public BankInfo BankInfo { get; set; }

        /// <summary>
        /// 认证请求号，对应一笔交易下的一次认证请求，不同认证请求需保证请求号唯一
        /// </summary>
        [JsonPropertyName("certify_request_no")]
        public string CertifyRequestNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user_info")]
        public UserIdentity UserInfo { get; set; }

        /// <summary>
        /// 用户类型：买家（BUYER）或卖家（SELLER）
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }

        /// <summary>
        /// 验证金额，单位为元，精确到小数点后两位，取值范围[0.01,0.5)
        /// </summary>
        [JsonPropertyName("validate_amount")]
        public string ValidateAmount { get; set; }
    }
}
