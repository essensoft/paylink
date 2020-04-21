using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceTitlelibraryDetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceTitlelibraryDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [JsonPropertyName("register_no")]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        /// <summary>
        /// 抬头名称
        /// </summary>
        [JsonPropertyName("title_name")]
        public string TitleName { get; set; }
    }
}
