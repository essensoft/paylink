using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TaxBillContent Data Structure.
    /// </summary>
    [Serializable]
    public class TaxBillContent : AlipayObject
    {
        /// <summary>
        /// 校验码
        /// </summary>
        [JsonProperty("anti_fake_code")]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("einv_amount")]
        public string EinvAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("einv_code")]
        public string EinvCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("einv_date")]
        public string EinvDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("einv_no")]
        public string EinvNo { get; set; }

        /// <summary>
        /// 卖方名称
        /// </summary>
        [JsonProperty("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 卖方纳税人识别号
        /// </summary>
        [JsonProperty("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 买方名称
        /// </summary>
        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 买方纳税人识别号
        /// </summary>
        [JsonProperty("payer_register_no")]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("without_tax_amount")]
        public string WithoutTaxAmount { get; set; }
    }
}
