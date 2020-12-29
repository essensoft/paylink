using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthQueryResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyAuthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 授权结果，枚举值（ok：授权成功，exist：已经存在）
        /// </summary>
        [JsonPropertyName("auth_result")]
        public string AuthResult { get; set; }

        /// <summary>
        /// 零花钱ID
        /// </summary>
        [JsonPropertyName("change_code_id")]
        public string ChangeCodeId { get; set; }

        /// <summary>
        /// 厂商家长ID
        /// </summary>
        [JsonPropertyName("vendor_parent_id")]
        public string VendorParentId { get; set; }
    }
}
