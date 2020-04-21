using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyQueryModel Data Structure.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// zimId，用于查询认证结果
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }
    }
}
