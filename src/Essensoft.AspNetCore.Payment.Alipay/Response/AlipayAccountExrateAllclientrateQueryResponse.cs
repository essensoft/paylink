using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateAllclientrateQueryResponse.
    /// </summary>
    public class AlipayAccountExrateAllclientrateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇率信息列表
        /// </summary>
        [JsonProperty("client_rate_list")]
        public List<ExClientRateVO> ClientRateList { get; set; }
    }
}
