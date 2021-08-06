using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopQueryModel Data Structure.
    /// </summary>
    public class AlipayBusinessRelationShopQueryModel : AlipayObject
    {
        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [JsonPropertyName("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [JsonPropertyName("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
