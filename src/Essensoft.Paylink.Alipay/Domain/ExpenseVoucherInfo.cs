using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExpenseVoucherInfo Data Structure.
    /// </summary>
    public class ExpenseVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 企业支付宝用户id(对应凭证ownerid)
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 消费时间
        /// </summary>
        [JsonPropertyName("consumption_date")]
        public string ConsumptionDate { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [JsonPropertyName("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 扩展预留
        /// </summary>
        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 数据创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 数据更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 行业
        /// </summary>
        [JsonPropertyName("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 是否冲抵凭证：0 否；1 是(如:红票)
        /// </summary>
        [JsonPropertyName("is_off_set")]
        public string IsOffSet { get; set; }

        /// <summary>
        /// 凭证介质：纸or电子(PAPER,ELECTRON)
        /// </summary>
        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        /// <summary>
        /// 外部唯一id
        /// </summary>
        [JsonPropertyName("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 凭证父类型（INVOICE-发票，TRAVEL-出行凭证，HTL_ORDER-酒店水单，CONSUME-账单，财政票夹）
        /// </summary>
        [JsonPropertyName("parent_type")]
        public string ParentType { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("voucher_amount")]
        public string VoucherAmount { get; set; }

        /// <summary>
        /// 凭证创建时间
        /// </summary>
        [JsonPropertyName("voucher_date")]
        public string VoucherDate { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 一类凭证，唯一号码，有必须传，没有可不传。 发票、账单必须有 如部分餐饮小票，没有唯一号
        /// </summary>
        [JsonPropertyName("voucher_no")]
        public string VoucherNo { get; set; }

        /// <summary>
        /// 凭证状态(0-无效，1 有效)
        /// </summary>
        [JsonPropertyName("voucher_state")]
        public string VoucherState { get; set; }

        /// <summary>
        /// 凭证类型 （FINANCIAL_BILLS-财政电子票 MEDICAL_INVOICE-医疗票据 DONATION_INVOICE-公益捐赠电子票据 SETTLEMENT_INVOICE-往来结算票据 DUES_INVOICE-社会团体会费收据 INVOICE-增值税票 PLAIN-增值税电子普通发票 SPECIAL-增值税专用发票 PLAIN_INVOICE-增值税普通发票 PAPER_INVOICE-增值税普通发票(卷式) CONSUME-账单 ALIPAY_CONSUME-支付宝账单 TRAVEL-出行凭证 TAXI-出租车票 BUS_TICKET-汽车票 TRAIN-火车票 TOLL-过路费 BOARD_PASS-登机牌 HTL_ORDER-酒店水单 MEMO-酒店水单 OTHERS-杂票 FIXED-定额发票 LIST-小票 COMMON_INVOICE-通用发票）
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }
    }
}
