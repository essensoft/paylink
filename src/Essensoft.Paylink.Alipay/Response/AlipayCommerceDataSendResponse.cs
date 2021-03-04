using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataSendResponse.
    /// </summary>
    public class AlipayCommerceDataSendResponse : AlipayResponse
    {
        /// <summary>
        /// data_send_business_result:数据发送业务处理结果信息
        /// </summary>
        [JsonPropertyName("data_send_business_result")]
        public DataSendBusinessResult DataSendBusinessResult { get; set; }
    }
}
