using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSearchOrderdetailQueryResponse.
    /// </summary>
    public class AlipayOpenSearchOrderdetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单详情
        /// </summary>
        [JsonPropertyName("data")]
        public SearchOrderDetailData Data { get; set; }
    }
}
