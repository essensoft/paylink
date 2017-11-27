using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAdvertModifyModel : AlipayObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonProperty("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表，数量限制：大于1个，小于3个，广告位轮播内容顺序，根据接口传入的顺序排列
        /// </summary>
        [JsonProperty("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
