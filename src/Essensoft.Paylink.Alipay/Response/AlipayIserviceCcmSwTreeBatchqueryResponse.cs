using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeBatchqueryResponse.
    /// </summary>
    public class AlipayIserviceCcmSwTreeBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目集合
        /// </summary>
        [JsonPropertyName("trees")]
        public TreeInfo Trees { get; set; }
    }
}
