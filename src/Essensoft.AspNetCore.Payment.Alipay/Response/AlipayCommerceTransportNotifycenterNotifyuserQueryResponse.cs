using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportNotifycenterNotifyuserQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportNotifycenterNotifyuserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订阅用户vo列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<NotifyUserVo> Result { get; set; }
    }
}
