using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
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
