using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPassTemplateUpdateModel Data Structure.
    /// </summary>
    public class AlipayPassTemplateUpdateModel : AlipayObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见tpl_content <a href="https://opendocs.alipay.com/open/016d5g">参数详细说明</a>。
        /// </summary>
        [JsonPropertyName("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 支付宝pass模版ID。通过<a href="https://opendocs.alipay.com/apis/api_24/alipay.pass.template.add">alipay.pass.template.add</a>(卡券模板创建接口)创建模板后返回的tpl_id。
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }
    }
}
