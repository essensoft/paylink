using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallAuditQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallAuditQueryModel : AlipayObject
    {
        /// <summary>
        /// koubei.shop.mall.page.modify(商圈主页地址创建修改接口)中 返回的工单id
        /// </summary>
        [JsonProperty("order_flow_id")]
        public string OrderFlowId { get; set; }
    }
}
