using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanPayAssetResult Data Structure.
    /// </summary>
    public class LoanPayAssetResult : AlipayObject
    {
        /// <summary>
        /// 资金账号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 可用额度
        /// </summary>
        [JsonPropertyName("available_amount")]
        public MultiCurrencyMoneyVO AvailableAmount { get; set; }

        /// <summary>
        /// true为可用，false为不可用
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 提示文案，JSON大字段
        /// </summary>
        [JsonPropertyName("hint_texts")]
        public string HintTexts { get; set; }

        /// <summary>
        /// 分期方案列表
        /// </summary>
        [JsonPropertyName("installments")]
        public List<LoanPayInstallment> Installments { get; set; }

        /// <summary>
        /// 不可用信息
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public Refuse RefuseMsg { get; set; }

        /// <summary>
        /// 方案id
        /// </summary>
        [JsonPropertyName("scheme_id")]
        public string SchemeId { get; set; }
    }
}
