using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSelleradmitQueryResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSelleradmitQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否已提交加白申请
        /// </summary>
        [JsonPropertyName("exsit")]
        public string Exsit { get; set; }

        /// <summary>
        /// 不准入原因代码
        /// </summary>
        [JsonPropertyName("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 门店不准入原因
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 门店是否为不准入
        /// </summary>
        [JsonPropertyName("refused")]
        public string Refused { get; set; }

        /// <summary>
        /// 是否加白成功
        /// </summary>
        [JsonPropertyName("white")]
        public string White { get; set; }
    }
}
