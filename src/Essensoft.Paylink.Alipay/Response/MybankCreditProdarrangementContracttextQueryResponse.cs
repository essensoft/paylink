using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditProdarrangementContracttextQueryResponse.
    /// </summary>
    public class MybankCreditProdarrangementContracttextQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合同内容
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
