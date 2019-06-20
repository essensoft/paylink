using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneFulfillmentlistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneFulfillmentlistSyncModel : AlipayObject
    {
        /// <summary>
        /// 信用订单号，即调用zhima.credit.ep.scene.agreement.use返回的信用订单号。
        /// </summary>
        [JsonProperty("credit_order_no")]
        public string CreditOrderNo { get; set; }

        /// <summary>
        /// 履约信息列表，最大不超过200项
        /// </summary>
        [JsonProperty("fulfillment_info_list")]
        public List<FulfillmentInfo> FulfillmentInfoList { get; set; }
    }
}
