using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderModifyResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单的申请单id，applyid
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
