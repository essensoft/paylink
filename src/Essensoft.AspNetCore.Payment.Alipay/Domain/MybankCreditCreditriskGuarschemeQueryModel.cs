using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryModel Data Structure.
    /// </summary>
    public class MybankCreditCreditriskGuarschemeQueryModel : AlipayObject
    {
        /// <summary>
        /// 担保方案查询类型，TYZBL：通用自保理业务场景
        /// </summary>
        [JsonPropertyName("bsn_type")]
        public string BsnType { get; set; }

        /// <summary>
        /// 销售产品码，特殊可选，某些场景是必填的
        /// </summary>
        [JsonPropertyName("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 用户身份信息
        /// </summary>
        [JsonPropertyName("user")]
        public Member User { get; set; }
    }
}
