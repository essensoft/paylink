using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyTradedetaillistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyTradedetaillistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易明细
        /// </summary>
        [JsonPropertyName("devicetradedetaillist")]
        public List<DeviceTradeDetail> Devicetradedetaillist { get; set; }

        /// <summary>
        /// 表示记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
