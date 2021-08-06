using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopDeleteModel Data Structure.
    /// </summary>
    public class AlipayBusinessRelationShopDeleteModel : AlipayObject
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
        /// 商业关系门店id alipay.agent.marketing.business.relation.shop.create接口返回
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
