using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCityserviceCertinfoQueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceCertinfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户证件信息查询结果列表。列表中的元素包含请求证件信息，以及对应的支付宝uid信息。
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<CertInfoResponse> ResultList { get; set; }
    }
}
