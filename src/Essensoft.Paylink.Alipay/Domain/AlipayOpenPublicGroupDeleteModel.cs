using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicGroupDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGroupDeleteModel : AlipayObject
    {
        /// <summary>
        /// 分组ID，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
