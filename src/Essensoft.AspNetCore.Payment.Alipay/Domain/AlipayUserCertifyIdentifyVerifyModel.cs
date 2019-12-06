using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyIdentifyVerifyModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyIdentifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 分配给业务的场景码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
