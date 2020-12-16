using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenAccountConsultModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenAccountConsultModel : AlipayObject
    {
        /// <summary>
        /// 账户名称
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户号
        /// </summary>
        [JsonPropertyName("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 银行代码包括：  美国银行abafw号  （aba/fw）  英国收款银行清算号(sort_code)  澳大利亚收款银行清算号(bsb_code)  加拿大收款银行清算号(cc_code)
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 学校id
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// swift code
        /// </summary>
        [JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
