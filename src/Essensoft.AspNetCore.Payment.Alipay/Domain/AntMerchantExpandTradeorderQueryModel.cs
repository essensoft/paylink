using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandTradeorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询结果中是否需要包含指定订单下商品订单，默认false，即不包含指定订单下的商品订单
        /// </summary>
        [JsonProperty("contain_item_order")]
        public bool ContainItemOrder { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
