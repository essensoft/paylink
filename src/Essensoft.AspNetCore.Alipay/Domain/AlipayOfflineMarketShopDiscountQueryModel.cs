using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopDiscountQueryModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopDiscountQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询类型 目前取值：MERCHANT(商户活动)，  如果不传递该参数或者指定参数值，出参只返回item_list，discount_list， 反之返回camp_num,camp_list
        /// </summary>
        [JsonProperty("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 门店id，注意:必须传递isv授权商户下的门店，否则无权限查询
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
