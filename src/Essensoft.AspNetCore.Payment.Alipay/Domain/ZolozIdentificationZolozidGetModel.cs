using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationZolozidGetModel Data Structure.
    /// </summary>
    public class ZolozIdentificationZolozidGetModel : AlipayObject
    {
        /// <summary>
        /// get region
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// bizId
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("extern_params")]
        public string ExternParams { get; set; }

        /// <summary>
        /// json字符串
        /// </summary>
        [JsonPropertyName("zcif_params")]
        public string ZcifParams { get; set; }
    }
}
