using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryResponse.
    /// </summary>
    public class KoubeiCateringPosStalldetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 档口模型
        /// </summary>
        [JsonPropertyName("stall_entity")]
        public StallEntity StallEntity { get; set; }
    }
}
