using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossProdAntlawSmartcontractcodeModifyResponse.
    /// </summary>
    public class AlipayBossProdAntlawSmartcontractcodeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("source_sys")]
        public string SourceSys { get; set; }
    }
}
