using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoAccountQueryModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 基金代码，必填。目前默认填001529，代表余利宝
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }
    }
}
