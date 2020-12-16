using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessagePreviewSendModel : AlipayObject
    {
        /// <summary>
        /// 预览用户登录id列表，每次做多发送5个用户，且这5个用户必须是生活号的管理员或者是操作员,
        /// </summary>
        [JsonPropertyName("logon_ids")]
        public List<string> LogonIds { get; set; }

        /// <summary>
        /// 推送的消息体信息
        /// </summary>
        [JsonPropertyName("msg_body")]
        public PublicMessageBody MsgBody { get; set; }
    }
}
