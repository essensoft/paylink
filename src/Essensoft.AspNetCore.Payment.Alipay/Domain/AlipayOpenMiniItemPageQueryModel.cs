using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniItemPageQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniItemPageQueryModel : AlipayObject
    {
        /// <summary>
        /// 商家侧商品ID列表，即导入商品信息时商家自定义商品ID。
        /// </summary>
        [JsonPropertyName("item_id_list")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 操作类型，固定为：ITEM_PAGEQUERY
        /// </summary>
        [JsonPropertyName("operation")]
        public string Operation { get; set; }

        /// <summary>
        /// 查询起始页码，默认为第一页 1。
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
