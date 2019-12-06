using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateActionMiniAppUrlDTO Data Structure.
    /// </summary>
    public class TemplateActionMiniAppUrlDTO : AlipayObject
    {
        /// <summary>
        /// 行动点按钮是否在列表页展示，true 或 false，不填则默认false；  列表页可以配置展示最多2项小程序跳转行动点。
        /// </summary>
        [JsonPropertyName("display_on_list")]
        public string DisplayOnList { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定小程序页面，不填则默认跳转至对应小程序首页
        /// </summary>
        [JsonPropertyName("mini_page_param")]
        public string MiniPageParam { get; set; }

        /// <summary>
        /// query参数，商户自定义传参，填入值将以"query"为参数名提交至指定小程序页面
        /// </summary>
        [JsonPropertyName("mini_query_param")]
        public string MiniQueryParam { get; set; }
    }
}
