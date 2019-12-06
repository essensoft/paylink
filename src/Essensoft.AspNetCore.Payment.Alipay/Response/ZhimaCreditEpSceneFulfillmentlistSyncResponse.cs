using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncResponse.
    /// </summary>
    public class ZhimaCreditEpSceneFulfillmentlistSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 履约同步结果列表
        /// </summary>
        [JsonPropertyName("fulfillment_result_list")]
        public List<FulfillmentResult> FulfillmentResultList { get; set; }
    }
}
