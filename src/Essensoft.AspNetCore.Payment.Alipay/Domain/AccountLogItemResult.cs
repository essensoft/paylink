using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccountLogItemResult Data Structure.
    /// </summary>
    public class AccountLogItemResult : AlipayObject
    {
        /// <summary>
        /// 支付宝账务流水号。对账使用，不脱敏
        /// </summary>
        [JsonPropertyName("account_log_id")]
        public string AccountLogId { get; set; }

        /// <summary>
        /// 支付宝订单号。对账使用，不脱敏
        /// </summary>
        [JsonPropertyName("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 余额，仅供参考。由于架构原因，余额变动并不保证连续。也就是余额不一定等于上一笔余额减去当笔金额。但是会保证最终一致。
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务账单来源，资金收支对应的上游业务订单数据来源，确认业务订单出处。此字段供商户对账使用，不脱敏。
        /// </summary>
        [JsonPropertyName("bill_source")]
        public string BillSource { get; set; }

        /// <summary>
        /// 业务描述，资金收支对应的详细业务场景信息。此字段供商户对账使用，不脱敏。
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务订单号，资金收支相关的业务场景订单号明细，字母大写；M：平台交易主单号，S：平台交易子单号，O：业务系统单据号（如退款订单号）。此字段供商户对账使用，不脱敏。
        /// </summary>
        [JsonPropertyName("biz_nos")]
        public string BizNos { get; set; }

        /// <summary>
        /// 业务基础订单号，资金收支对应的原始业务订单唯一识别编号。此字段供商户对账使用，不脱敏。
        /// </summary>
        [JsonPropertyName("biz_orig_no")]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 收入/支出。表示收支。amount是正数，返回“收入”。amount是负数，返回“支出”
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 对方账户
        /// </summary>
        [JsonPropertyName("other_account")]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }

        /// <summary>
        /// 入账时间
        /// </summary>
        [JsonPropertyName("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 账务备注。由上游业务决定，不可依赖此字段进行对账
        /// </summary>
        [JsonPropertyName("trans_memo")]
        public string TransMemo { get; set; }

        /// <summary>
        /// 账务记录的类型，仅供参考
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
