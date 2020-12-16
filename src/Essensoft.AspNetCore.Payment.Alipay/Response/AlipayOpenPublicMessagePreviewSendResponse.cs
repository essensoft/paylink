using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessagePreviewSendResponse.
    /// </summary>
    public class AlipayOpenPublicMessagePreviewSendResponse : AlipayResponse
    {
        /// <summary>
        /// 消息发送错误数据
        /// </summary>
        [JsonPropertyName("error_datas")]
        public List<MsgSendErrorData> ErrorDatas { get; set; }
    }
}
