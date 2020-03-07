using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolPrintSendResponse : AlipayResponse
    {
        /// <summary>
        /// 打印任务编号
        /// </summary>
        [JsonPropertyName("print_no")]
        public string PrintNo { get; set; }
    }
}
