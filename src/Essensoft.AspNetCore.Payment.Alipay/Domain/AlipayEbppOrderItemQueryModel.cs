using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppOrderItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppOrderItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 机构端订单项id列表
        /// </summary>
        [JsonProperty("inst_item_id")]
        public string InstItemId { get; set; }
    }
}
