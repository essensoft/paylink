using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedAdvertCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。
        /// </summary>
        [JsonPropertyName("advert_items")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 人群分组id，修改为 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>(用户分组创建接口)创建人群分组获取。
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，支持：iphone、android、wp。不填表示不区分机型。
        /// </summary>
        [JsonPropertyName("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
