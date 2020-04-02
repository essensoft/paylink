using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvTroublefreeruleConsultModel Data Structure.
    /// </summary>
    public class AlipayIserviceMindvTroublefreeruleConsultModel : AlipayObject
    {
        /// <summary>
        /// 问卷ID值，调研平台获取
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 产品ID值，调研平台进行查询
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
