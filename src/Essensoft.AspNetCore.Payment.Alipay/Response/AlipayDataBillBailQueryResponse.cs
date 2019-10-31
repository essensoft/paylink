using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillBailQueryResponse.
    /// </summary>
    public class AlipayDataBillBailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 保证金明细列表，最多返回5000条
        /// </summary>
        [JsonProperty("detail_list")]
        public List<BailDetailResult> DetailList { get; set; }
    }
}
