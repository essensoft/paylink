using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanChargeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LoanChargeInfo : AlipayObject
    {
        /// <summary>
        /// 费用编码
        /// </summary>
        [JsonProperty("charge_code")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [JsonProperty("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 分段费率
        /// </summary>
        [JsonProperty("instal_chrg_rate")]
        public InstallmentValue InstalChrgRate { get; set; }
    }
}
