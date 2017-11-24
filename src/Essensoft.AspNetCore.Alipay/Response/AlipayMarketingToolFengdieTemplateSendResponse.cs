using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieTemplateSendResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieTemplateSendResponse : AlipayResponse
    {
        /// <summary>
        /// 分配模板的操作是否成功
        /// </summary>
        [JsonProperty("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
