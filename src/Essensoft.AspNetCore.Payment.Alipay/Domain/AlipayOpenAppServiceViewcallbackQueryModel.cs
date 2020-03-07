using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceViewcallbackQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceViewcallbackQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务视图元数据ID
        /// </summary>
        [JsonPropertyName("service_view_meta_id")]
        public string ServiceViewMetaId { get; set; }
    }
}
