using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishQuerydishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishQuerydishQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜品信息
        /// </summary>
        [JsonPropertyName("dish_info_list")]
        public List<KbdishSimplyInfo> DishInfoList { get; set; }

        /// <summary>
        /// 是否需要重试，true：是；false：不需要
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
