using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanChargeInfo Data Structure.
    /// </summary>
    public class LoanChargeInfo : AlipayObject
    {
        /// <summary>
        /// 费用编码
        /// </summary>
        [JsonPropertyName("charge_code")]
        public string ChargeCode { get; set; }

        /// <summary>
        /// 费用名称
        /// </summary>
        [JsonPropertyName("charge_name")]
        public string ChargeName { get; set; }

        /// <summary>
        /// 分段费率
        /// </summary>
        [JsonPropertyName("instal_chrg_rate")]
        public InstallmentValue InstalChrgRate { get; set; }
    }
}
