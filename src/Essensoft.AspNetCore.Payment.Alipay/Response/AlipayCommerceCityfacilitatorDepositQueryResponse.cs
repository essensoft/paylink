using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorDepositQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorDepositQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 待圈存明细
        /// </summary>
        [JsonPropertyName("recharge_bills")]
        public List<RechargeBill> RechargeBills { get; set; }
    }
}
