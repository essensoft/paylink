using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PassTemplateDetail Data Structure.
    /// </summary>
    public class PassTemplateDetail : AlipayObject
    {
        /// <summary>
        /// 模板创建时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 模板最后修改时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 模板内容信息文本，遵循JSON规范，即创建模板时传入tpl_content字段；  详情参见tpl_content参数说明：https://doc.open.alipay.com/doc2/detail.htm?treeId=193&articleId=105249&docType=1#tpl_content
        /// </summary>
        [JsonPropertyName("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 模板ID（编号）
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模板上定制的动态参数（变量）列表
        /// </summary>
        [JsonPropertyName("tpl_params")]
        public List<string> TplParams { get; set; }
    }
}
