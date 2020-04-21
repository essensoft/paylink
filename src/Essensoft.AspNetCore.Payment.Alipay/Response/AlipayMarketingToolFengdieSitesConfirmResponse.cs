using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesConfirmResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 返回执行云凤蝶站点审核操作的成功失败状态
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
