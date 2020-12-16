using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainFinancePfQuotaQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinancePfQuotaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 额度协议书编号
        /// </summary>
        [JsonPropertyName("agrm_bk_no")]
        public string AgrmBkNo { get; set; }

        /// <summary>
        /// 授信额度
        /// </summary>
        [JsonPropertyName("cr_limit")]
        public string CrLimit { get; set; }

        /// <summary>
        /// 额度编号
        /// </summary>
        [JsonPropertyName("lmt_no")]
        public string LmtNo { get; set; }

        /// <summary>
        /// 额度状态
        /// </summary>
        [JsonPropertyName("lmt_status")]
        public string LmtStatus { get; set; }

        /// <summary>
        /// 个性化参数
        /// </summary>
        [JsonPropertyName("parm")]
        public string Parm { get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        [JsonPropertyName("remain_limit")]
        public string RemainLimit { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonPropertyName("trans_no")]
        public string TransNo { get; set; }
    }
}
