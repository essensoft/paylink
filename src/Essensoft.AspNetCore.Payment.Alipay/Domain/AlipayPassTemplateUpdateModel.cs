using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassTemplateUpdateModel Data Structure.
    /// </summary>
    public class AlipayPassTemplateUpdateModel : AlipayObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见tpl_content参数说明:https://doc.open.alipay.com/doc2/detail.htm?treeId=193&articleId=105249&docType=1#tpl_content
        /// </summary>
        [JsonPropertyName("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 更新的模板ID，即调用模板创建接口时返回的tpl_id。
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }
    }
}
