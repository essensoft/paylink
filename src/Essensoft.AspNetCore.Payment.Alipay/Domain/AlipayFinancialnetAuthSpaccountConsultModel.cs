using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountConsultModel Data Structure.
    /// </summary>
    public class AlipayFinancialnetAuthSpaccountConsultModel : AlipayObject
    {
        /// <summary>
        /// 业务标识ID
        /// </summary>
        [JsonPropertyName("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 签约产品ID
        /// </summary>
        [JsonPropertyName("sign_product_id")]
        public string SignProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
