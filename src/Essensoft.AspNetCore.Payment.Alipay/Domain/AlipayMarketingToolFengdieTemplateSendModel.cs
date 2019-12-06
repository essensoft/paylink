using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendModel : AlipayObject
    {
        /// <summary>
        /// 企业 VIP 用户的ID（以 2088 开头的ID）
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲分配站点模板的空间业务 ID 列表
        /// </summary>
        [JsonPropertyName("space_ids")]
        public List<string> SpaceIds { get; set; }

        /// <summary>
        /// 欲分配的站点模板的名称，可以在模板包的 package.json 文件中找到 name 字段
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
