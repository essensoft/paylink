using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthPbcQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthPbcQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 联行号
        /// </summary>
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonPropertyName("branch_name")]
        public string BranchName { get; set; }

        /// <summary>
        /// 城市信息
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 顶级机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 顶级机构名称
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 省份信息
        /// </summary>
        [JsonPropertyName("provice")]
        public string Provice { get; set; }

        /// <summary>
        /// 承接的清算机构
        /// </summary>
        [JsonPropertyName("undertake_inst")]
        public string UndertakeInst { get; set; }
    }
}
