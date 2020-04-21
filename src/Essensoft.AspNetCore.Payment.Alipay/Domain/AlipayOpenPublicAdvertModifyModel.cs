using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAdvertModifyModel : AlipayObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonPropertyName("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表，数量限制：大于1个，小于3个，广告位轮播内容顺序，根据接口传入的顺序排列
        /// </summary>
        [JsonPropertyName("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
