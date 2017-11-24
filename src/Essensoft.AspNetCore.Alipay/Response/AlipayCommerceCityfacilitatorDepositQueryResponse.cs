using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待圈存明细
        /// </summary>
        [JsonProperty("recharge_bills")]
        public List<RechargeBill> RechargeBills { get; set; }
    }
}
