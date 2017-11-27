using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// Advert Data Structure.
    /// </summary>
    public class Advert : AlipayObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonProperty("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        [JsonProperty("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
