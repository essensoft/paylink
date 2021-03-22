using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeLabelModifyModel : AlipayObject
    {
        /// <summary>
        /// 标签 id，只支持生活号自定义标签。通过 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.life.label.create">alipay.open.public.life.label.create</a>(创建标签接口)创建自定义标签后获取。
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonPropertyName("label_name")]
        public string LabelName { get; set; }
    }
}
