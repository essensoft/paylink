using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceQueryModel : AlipayObject
    {
        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲查询的空间 ID
        /// </summary>
        [JsonPropertyName("space_id")]
        public string SpaceId { get; set; }
    }
}
