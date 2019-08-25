using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanPayAssetResult Data Structure.
    /// </summary>
    [Serializable]
    public class LoanPayAssetResult : AlipayObject
    {
        /// <summary>
        /// 资金账号
        /// </summary>
        [JsonProperty("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 可用额度
        /// </summary>
        [JsonProperty("available_amount")]
        public MultiCurrencyMoneyVO AvailableAmount { get; set; }

        /// <summary>
        /// true为可用，false为不可用
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 提示文案，JSON大字段
        /// </summary>
        [JsonProperty("hint_texts")]
        public string HintTexts { get; set; }

        /// <summary>
        /// 分期方案列表
        /// </summary>
        [JsonProperty("installments")]
        public List<LoanPayInstallment> Installments { get; set; }

        /// <summary>
        /// 不可用信息
        /// </summary>
        [JsonProperty("refuse_msg")]
        public Refuse RefuseMsg { get; set; }

        /// <summary>
        /// 方案id
        /// </summary>
        [JsonProperty("scheme_id")]
        public string SchemeId { get; set; }
    }
}
