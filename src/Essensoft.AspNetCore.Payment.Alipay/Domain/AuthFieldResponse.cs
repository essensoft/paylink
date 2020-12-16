using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthFieldResponse Data Structure.
    /// </summary>
    public class AuthFieldResponse : AlipayObject
    {
        /// <summary>
        /// 用户信息申请记录列表
        /// </summary>
        [JsonPropertyName("records")]
        public List<AuthFieldDTO> Records { get; set; }
    }
}
