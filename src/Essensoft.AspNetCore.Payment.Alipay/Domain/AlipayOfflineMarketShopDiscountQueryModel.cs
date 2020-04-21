using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopDiscountQueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopDiscountQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动业务类型列表，当query_type为MERCHANT且user_id不为空时生效，对返回结果进行过滤，返回列表中指定业务类型的活动，默认为空，代表不过滤，返回所有活动。业务类型：CONSUME_SEND：消费送；MRT_DISCOUNT:商户立减；OBTAIN:通用领券
        /// </summary>
        [JsonPropertyName("camp_biz_type_list")]
        public List<string> CampBizTypeList { get; set; }

        /// <summary>
        /// 查询类型 目前取值：MERCHANT(商户活动)，  如果不传递该参数或者指定参数值，出参只返回item_list，discount_list， 反之返回camp_num,camp_list
        /// </summary>
        [JsonPropertyName("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 门店id，注意:必须传递isv授权商户下的门店，否则无权限查询
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户id，当query_type为MERCHANT时生效，如果查询的优惠活动需要过用户规则，则用户id必须传入，目前只支持查询活动列表的场景
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
