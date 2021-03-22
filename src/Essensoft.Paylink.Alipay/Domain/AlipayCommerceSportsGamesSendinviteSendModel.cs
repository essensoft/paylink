using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsGamesSendinviteSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsGamesSendinviteSendModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 信息描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 好友open_id
        /// </summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
