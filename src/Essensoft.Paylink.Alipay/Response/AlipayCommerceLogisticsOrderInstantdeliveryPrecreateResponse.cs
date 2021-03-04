using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponse.
    /// </summary>
    public class AlipayCommerceLogisticsOrderInstantdeliveryPrecreateResponse : AlipayResponse
    {
        /// <summary>
        /// 即时配送运单列表
        /// </summary>
        [JsonPropertyName("waybills")]
        public List<PreCreateWaybillIstd> Waybills { get; set; }
    }
}
