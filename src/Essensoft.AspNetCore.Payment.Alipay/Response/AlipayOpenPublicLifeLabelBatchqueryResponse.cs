using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonPropertyName("labels")]
        public List<LifeLabel> Labels { get; set; }
    }
}
