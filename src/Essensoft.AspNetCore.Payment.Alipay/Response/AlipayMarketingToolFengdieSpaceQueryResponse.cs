using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 空间详情信息，比如空间名称、空间管理员等信息
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSpaceDetailModel Data { get; set; }
    }
}
