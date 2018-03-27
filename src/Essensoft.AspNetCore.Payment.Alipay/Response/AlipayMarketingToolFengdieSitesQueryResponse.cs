using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [JsonProperty("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}
