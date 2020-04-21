using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TaxBillContent Data Structure.
    /// </summary>
    public class TaxBillContent : AlipayObject
    {
        /// <summary>
        /// 校验码
        /// </summary>
        [JsonPropertyName("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 复审
        /// </summary>
        [JsonPropertyName("checker")]
        public string Checker { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        [JsonPropertyName("clerk")]
        public string Clerk { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonPropertyName("einv_amount")]
        public string EinvAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("einv_code")]
        public string EinvCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonPropertyName("einv_date")]
        public string EinvDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("einv_no")]
        public string EinvNo { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        [JsonPropertyName("payee")]
        public string Payee { get; set; }

        /// <summary>
        /// 卖方地址、电话
        /// </summary>
        [JsonPropertyName("payee_address")]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 卖方开户行
        /// </summary>
        [JsonPropertyName("payee_bank_name")]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 卖方名称
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 卖方纳税人识别号
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 买方地址、电话
        /// </summary>
        [JsonPropertyName("payer_address")]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 买方开户行
        /// </summary>
        [JsonPropertyName("payer_bank_name")]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 买方名称
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 买方纳税人识别号
        /// </summary>
        [JsonPropertyName("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 价税合计（大写）
        /// </summary>
        [JsonPropertyName("sum_amount")]
        public string SumAmount { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
