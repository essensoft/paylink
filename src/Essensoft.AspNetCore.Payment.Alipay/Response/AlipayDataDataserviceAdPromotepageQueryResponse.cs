using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 留资页信息列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<PromotePage> List { get; set; }
    }
}
