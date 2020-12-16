using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniShopRelationQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniShopRelationQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店 ID 列表。支付宝门店（蚂蚁门店）的 ShopID。
        /// </summary>
        [JsonPropertyName("entity_id_list")]
        public List<string> EntityIdList { get; set; }

        /// <summary>
        /// 操作类型，固定为：MINIAPP_SHOP_PAGEQUERY
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量，最大不超过20，默认10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
