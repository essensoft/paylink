using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLabelQueryResponse.
    /// </summary>
    public class AlipayOpenPublicLabelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 该服务窗拥有的标签列表
        /// </summary>
        [JsonPropertyName("label_list")]
        public List<PublicLabel> LabelList { get; set; }
    }
}
