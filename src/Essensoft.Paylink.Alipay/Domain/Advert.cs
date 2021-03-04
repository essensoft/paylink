using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Advert Data Structure.
    /// </summary>
    public class Advert : AlipayObject
    {
        /// <summary>
        /// 广告组标识
        /// </summary>
        [JsonPropertyName("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        [JsonPropertyName("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        [JsonPropertyName("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 投放人群分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,空为不区分机型
        /// </summary>
        [JsonPropertyName("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
