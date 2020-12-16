using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateInfoBean Data Structure.
    /// </summary>
    public class TemplateInfoBean : AlipayObject
    {
        /// <summary>
        /// 模板填充项，根据组件key值传入填写内容
        /// </summary>
        [JsonPropertyName("fill_contents")]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 签署文件名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 签署区，根据签署区key值传入对应的签署人信息
        /// </summary>
        [JsonPropertyName("signfields")]
        public List<SignFieldBean> Signfields { get; set; }

        /// <summary>
        /// 模板id，通过创建合同模板获取
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
