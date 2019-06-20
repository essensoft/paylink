using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsDeliveryorderprocessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsDeliveryorderprocessQueryModel : AlipayObject
    {
        /// <summary>
        /// 通知单id
        /// </summary>
        [JsonProperty("notice_order_id")]
        public string NoticeOrderId { get; set; }
    }
}
