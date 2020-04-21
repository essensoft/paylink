using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailCreateResponse.
    /// </summary>
    public class ZhimaMerchantCreditserviceDetailCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 信用服务ID，是成功创建信用服务的ID。
        /// </summary>
        [JsonPropertyName("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 信用服务版本号，是成功创建信用服务的版本号。
        /// </summary>
        [JsonPropertyName("version_no")]
        public string VersionNo { get; set; }
    }
}
