using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillBailQueryResponse.
    /// </summary>
    public class AlipayDataBillBailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保证金明细列表，最多返回5000条
        /// </summary>
        [JsonPropertyName("detail_list")]
        public List<BailDetailResult> DetailList { get; set; }
    }
}
