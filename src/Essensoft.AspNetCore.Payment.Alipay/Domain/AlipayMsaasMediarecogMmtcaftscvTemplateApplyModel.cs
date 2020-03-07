using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateApplyModel Data Structure.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvTemplateApplyModel : AlipayObject
    {
        /// <summary>
        /// 模板编号
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
