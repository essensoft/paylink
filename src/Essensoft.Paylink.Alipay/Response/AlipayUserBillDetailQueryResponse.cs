using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayUserBillDetailQueryResponse.
    /// </summary>
    public class AlipayUserBillDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消费记录模型
        /// </summary>
        [JsonPropertyName("consume_record")]
        public ConsumeRecord ConsumeRecord { get; set; }
    }
}
