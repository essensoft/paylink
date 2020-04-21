using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantCreditserviceDetailQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantCreditserviceDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 信用服务ID，为必传字段。
        /// </summary>
        [JsonPropertyName("credit_service_id")]
        public string CreditServiceId { get; set; }

        /// <summary>
        /// 信用服务版本的版本号。
        /// </summary>
        [JsonPropertyName("version_no")]
        public string VersionNo { get; set; }
    }
}
