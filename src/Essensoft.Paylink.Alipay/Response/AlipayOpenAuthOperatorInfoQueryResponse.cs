using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthOperatorInfoQueryResponse.
    /// </summary>
    public class AlipayOpenAuthOperatorInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 操作员基础信息
        /// </summary>
        [JsonPropertyName("operator_info")]
        public OperatorBasicInfo OperatorInfo { get; set; }
    }
}
