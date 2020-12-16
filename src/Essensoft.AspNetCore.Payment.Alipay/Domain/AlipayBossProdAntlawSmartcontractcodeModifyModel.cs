using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawSmartcontractcodeModifyModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlawSmartcontractcodeModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 合同编号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 鉴权token
        /// </summary>
        [JsonPropertyName("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [JsonPropertyName("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
