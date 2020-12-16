using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniShopRelationBindModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniShopRelationBindModel : AlipayObject
    {
        /// <summary>
        /// 门店信息，entity_id为平台侧门店id，property_list属性列表详见产品文档
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
