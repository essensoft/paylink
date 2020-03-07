using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditCreditriskCustlabelQueryResponse.
    /// </summary>
    public class AlipayPcreditCreditriskCustlabelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否展示借呗
        /// </summary>
        [JsonPropertyName("show_jb")]
        public bool ShowJb { get; set; }

        /// <summary>
        /// 是否展示网商
        /// </summary>
        [JsonPropertyName("show_my")]
        public bool ShowMy { get; set; }
    }
}
