using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
