using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishEstimateQueryResponse.
    /// </summary>
    public class KoubeiCateringDishEstimateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品估清信息
        /// </summary>
        [JsonPropertyName("dish_info_list")]
        public List<EstimateDishInfo> DishInfoList { get; set; }

        /// <summary>
        /// 失败下是否可以重试，true：需要；false：不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
