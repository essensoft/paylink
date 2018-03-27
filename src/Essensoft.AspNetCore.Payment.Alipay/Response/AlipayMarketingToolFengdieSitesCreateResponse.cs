using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建站点的返回值模型
        /// </summary>
        [JsonProperty("data")]
        public FengdieActivityCreateModel Data { get; set; }
    }
}
