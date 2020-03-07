using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserLogonidMaskedQueryResponse.
    /// </summary>
    public class AlipayUserLogonidMaskedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 脱敏后的登录名视图。【注意】如果入参中某一userId不存在，返回的视图列表中将不包含该userId对应视图。（举例：入参里10个userId，其中1个userId不存在，则出参列表里有9个视图）
        /// </summary>
        [JsonPropertyName("logon_id_views")]
        public List<MaskedLogonIdView> LogonIdViews { get; set; }
    }
}
