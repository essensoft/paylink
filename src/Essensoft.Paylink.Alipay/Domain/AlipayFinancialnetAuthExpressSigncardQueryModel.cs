using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthExpressSigncardQueryModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthExpressSigncardQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [JsonPropertyName("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
