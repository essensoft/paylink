using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvTemplateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmtcaftscvTemplateApplyModel : AlipayObject
    {
        /// <summary>
        /// 模板编号
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
