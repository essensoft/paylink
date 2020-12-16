using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedAdvertCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告位轮播内容列表，数量限制：大于1个，小于5个，广告位轮播内容顺序，根据接口传入的顺序排列
        /// </summary>
        [JsonPropertyName("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 人群分组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,不填为不区分机型
        /// </summary>
        [JsonPropertyName("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
