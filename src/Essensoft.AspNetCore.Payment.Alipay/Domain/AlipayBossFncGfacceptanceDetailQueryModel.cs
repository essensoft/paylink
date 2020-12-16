using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfacceptanceDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfacceptanceDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 16位。支付宝UID或者2088000000000XX0，倒数2、3位数字用来决策LDC ZoneUid和分库位
        /// </summary>
        [JsonPropertyName("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 业财受理查询请求体
        /// </summary>
        [JsonPropertyName("query")]
        public GFAOpenAPIQueryRequest Query { get; set; }
    }
}
