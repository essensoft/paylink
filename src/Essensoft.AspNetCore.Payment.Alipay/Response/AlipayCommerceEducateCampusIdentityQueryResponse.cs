using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateCampusIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateCampusIdentityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询用户是否目前是大学生
        /// </summary>
        [JsonPropertyName("college_online_tag")]
        public string CollegeOnlineTag { get; set; }
    }
}
