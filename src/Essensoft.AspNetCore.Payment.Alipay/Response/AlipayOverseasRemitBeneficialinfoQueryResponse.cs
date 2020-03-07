using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasRemitBeneficialinfoQueryResponse.
    /// </summary>
    public class AlipayOverseasRemitBeneficialinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 收端用户的收款卡号
        /// </summary>
        [JsonPropertyName("bank_account")]
        public string BankAccount { get; set; }

        /// <summary>
        /// 银行机构英文名字
        /// </summary>
        [JsonPropertyName("bank_english_name")]
        public string BankEnglishName { get; set; }

        /// <summary>
        /// 银行的机构Id
        /// </summary>
        [JsonPropertyName("bank_inst_id")]
        public string BankInstId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 是否有同步返回结果
        /// </summary>
        [JsonPropertyName("has_sync_result")]
        public bool HasSyncResult { get; set; }
    }
}
