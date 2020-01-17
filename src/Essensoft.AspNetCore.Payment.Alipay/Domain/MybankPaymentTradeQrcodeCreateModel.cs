using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeQrcodeCreateModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeQrcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 账户分类 对私 private；对公 public
        /// </summary>
        [JsonPropertyName("account_category")]
        public string AccountCategory { get; set; }

        /// <summary>
        /// 账户类型 外部卡：OUT_BANK，云资金账号：CLOUND_ACCOUNT  网商银行卡：  MYBANK
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 订单金额 动态码场景必填，金额分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 业务订单单号  动态码场景必填
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 开户行的联行号
        /// </summary>
        [JsonPropertyName("branch_inst_code")]
        public string BranchInstCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 渠道 开放平台openPlatform 金蝉平台 jinChan
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 币种 默认是CNY，动态码场景选填
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 企业方案合约号
        /// </summary>
        [JsonPropertyName("enterprise_scheme_ar_no")]
        public string EnterpriseSchemeArNo { get; set; }

        /// <summary>
        /// 总行联行号
        /// </summary>
        [JsonPropertyName("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 失效时间  yyyy-MM-dd HH:mm:ss格式的
        /// </summary>
        [JsonPropertyName("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 订单扩展字段 JSON格式，UTF-8编码
        /// </summary>
        [JsonPropertyName("order_ext")]
        public string OrderExt { get; set; }

        /// <summary>
        /// 个人方案合约号
        /// </summary>
        [JsonPropertyName("personal_scheme_ar_no")]
        public string PersonalSchemeArNo { get; set; }

        /// <summary>
        /// 二维码类型 DYNAMIC_CODE STATIC_COD
        /// </summary>
        [JsonPropertyName("qr_code_type")]
        public string QrCodeType { get; set; }

        /// <summary>
        /// 收款银行账户的名称
        /// </summary>
        [JsonPropertyName("receipt_account_name")]
        public string ReceiptAccountName { get; set; }

        /// <summary>
        /// 收款银行卡号
        /// </summary>
        [JsonPropertyName("receipt_account_no")]
        public string ReceiptAccountNo { get; set; }
    }
}
