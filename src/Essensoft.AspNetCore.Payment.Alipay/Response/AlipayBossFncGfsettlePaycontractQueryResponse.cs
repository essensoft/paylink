using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<PayContractItemApplyDTO> ResultSet { get; set; }
    }
}
