using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("fulfillment_result_list")]
        public List<FulfillmentResult> FulfillmentResultList { get; set; }
    }
}
