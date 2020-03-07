using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppProdmodeUnionbankQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeUnionbankQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 银联编号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 联行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 市区信息
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [JsonPropertyName("prov")]
        public string Prov { get; set; }
    }
}
