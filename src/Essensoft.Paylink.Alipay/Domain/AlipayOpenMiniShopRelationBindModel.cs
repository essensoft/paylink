using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniShopRelationBindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniShopRelationBindModel : AlipayObject
    {
        /// <summary>
        /// 门店信息，entity_id为平台侧门店id，property_list属性列表详见 <a href="https://opendocs.alipay.com/mini/00nvud">绑定门店</a>。
        /// </summary>
        [JsonPropertyName("entity_info")]
        public List<MiniEntityBindInfo> EntityInfo { get; set; }

        /// <summary>
        /// 操作类型，固定为：MINIAPP_SHOP
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }
    }
}
