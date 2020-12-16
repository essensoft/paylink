using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceOpenRedCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceOpenRedCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户申请开具的蓝票冲红时必须提供，用于交付用户发票，来自用户开票通知
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否自动填充开票信息； 当为invoice_type=red且auto_fill_info=true时： 购买方信息(payer_)， 销方信息（payee_), 发票明细项，发票金额将以发票平台原始蓝票为准开出红票； 为空或者为非true时，则按本接口请求参数为准
        /// </summary>
        [JsonPropertyName("auto_fill_info")]
        public bool AutoFillInfo { get; set; }

        /// <summary>
        /// 是否需要预处理发票，当为true时发票即根据发票明细项invoice_item进行计算加税合计金额
        /// </summary>
        [JsonPropertyName("auto_preprocess")]
        public bool AutoPreprocess { get; set; }

        /// <summary>
        /// 合计含税金额（开票金额），格式为2位小数，单位元； 当开红票时，该字段为负数。 invoice_type=blue时必须填写 invoice_type=red 并且 auto_fill_info=false时必填
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 电子发票明细 当invoice_type=red且auto_fill_info=true时可不填，其他情况必须要填写
        /// </summary>
        [JsonPropertyName("invoice_items")]
        public List<GeneralInvoiceItem> InvoiceItems { get; set; }

        /// <summary>
        /// 税控产品发票类型 可选值： 0: 电票 1：纸质普票 2：纸质专票
        /// </summary>
        [JsonPropertyName("invoice_kind")]
        public long InvoiceKind { get; set; }

        /// <summary>
        /// 开票备注信息， 若invoice_type=red 并且 auto_fill_info=false时，此处填写原始蓝票代码+原始蓝票号码
        /// </summary>
        [JsonPropertyName("invoice_memo")]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票(开票)类型， 可选值：蓝票blue, 红票red
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 原发票代码(冲红时必须)
        /// </summary>
        [JsonPropertyName("normal_invoice_code")]
        public string NormalInvoiceCode { get; set; }

        /// <summary>
        /// 原发票号码(冲红时必须)
        /// </summary>
        [JsonPropertyName("normal_invoice_no")]
        public string NormalInvoiceNo { get; set; }

        /// <summary>
        /// 开票申请id
        /// </summary>
        [JsonPropertyName("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 销方地址 销方电话加地址不超出100字符 auto_fill_info=false时必填
        /// </summary>
        [JsonPropertyName("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方银行账户id
        /// </summary>
        [JsonPropertyName("payee_bank_account_id")]
        public string PayeeBankAccountId { get; set; }

        /// <summary>
        /// 销售方银行账户开户行名称 开户行账号加名称不超出100字符
        /// </summary>
        [JsonPropertyName("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        [JsonPropertyName("payee_checker")]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 销方名称，公司名(如:XX商城)
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 开票人 auto_fill_info=false时必填
        /// </summary>
        [JsonPropertyName("payee_operator")]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [JsonPropertyName("payee_phone")]
        public string PayeePhone { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonPropertyName("payee_receiver")]
        public string PayeeReceiver { get; set; }

        /// <summary>
        /// 销方税务登记证号，auto_fill_info=false时必填
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        [JsonPropertyName("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方银行账户
        /// </summary>
        [JsonPropertyName("payer_bank_account_id")]
        public string PayerBankAccountId { get; set; }

        /// <summary>
        /// 购方开户行名称，开户行账号加名称不超出100字符
        /// </summary>
        [JsonPropertyName("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [JsonPropertyName("payer_phone")]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购方方税务登记证号。 开企业抬头时必填。
        /// </summary>
        [JsonPropertyName("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 业务平台编码，由发票平台分配
        /// </summary>
        [JsonPropertyName("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 商户在业务平台的唯一标志
        /// </summary>
        [JsonPropertyName("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 税控产品Code，由中台定义的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 合计金额，格式为2位小数，单位元。 当开红票时，该字段为负数
        /// </summary>
        [JsonPropertyName("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 合计税额，格式为2位小数。 当开红票时，该字段为负数
        /// </summary>
        [JsonPropertyName("sum_tax")]
        public string SumTax { get; set; }
    }
}
