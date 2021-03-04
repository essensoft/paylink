using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserAgreementBatchQueryResponse.
    /// </summary>
    public class AlipayUserAgreementBatchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户签约协议列表
        /// </summary>
        [JsonPropertyName("usage_agreement_info_list")]
        public List<OpenApiSignQueryResponse> UsageAgreementInfoList { get; set; }
    }
}
