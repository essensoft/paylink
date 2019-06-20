using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMemberRetailerQueryResponse.
    /// </summary>
    public class KoubeiMemberRetailerQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 零售商信息列表
        /// </summary>
        [JsonProperty("retailer_list")]
        public List<Retailer> RetailerList { get; set; }
    }
}
