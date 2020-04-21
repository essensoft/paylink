using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplatemessageUsertemplateApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniTemplatemessageUsertemplateApplyModel : AlipayObject
    {
        /// <summary>
        /// 开发者自行组合好的模板关键词列表，关键词之间使用英文的逗号“,”进行分割，关键词顺序可以自由搭配，最多支持10个关键词组合,这里组织的关键词，在发送模板消息接口中，按照这里的顺序进行占位符替换
        /// </summary>
        [JsonPropertyName("keyword_list")]
        public string KeywordList { get; set; }

        /// <summary>
        /// 模板库id，可登录小程序后台查看获取
        /// </summary>
        [JsonPropertyName("template_library_id")]
        public string TemplateLibraryId { get; set; }
    }
}
