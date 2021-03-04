using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
