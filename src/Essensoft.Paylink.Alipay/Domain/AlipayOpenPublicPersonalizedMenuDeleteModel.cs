using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuDeleteModel : AlipayObject
    {
        /// <summary>
        /// 要删除的个性化菜单key。通过 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.personalized.menu.create">alipay.open.public.personalized.menu.create</a>(个性化菜单创建)接口创建个性化菜单后获取。
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }
    }
}
