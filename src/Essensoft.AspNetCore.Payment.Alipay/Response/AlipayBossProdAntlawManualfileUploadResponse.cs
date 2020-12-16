using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdAntlawManualfileUploadResponse.
    /// </summary>
    public class AlipayBossProdAntlawManualfileUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 智能撰写生成的合同ID,用于查询合同详情
        /// </summary>
        [JsonPropertyName("smart_contract_id")]
        public string SmartContractId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("source_sys")]
        public string SourceSys { get; set; }
    }
}
