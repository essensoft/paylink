using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppOrderItemCancelModel : AlipayObject
    {
        /// <summary>
        /// 机构订单子项id
        /// </summary>
        [JsonProperty("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
