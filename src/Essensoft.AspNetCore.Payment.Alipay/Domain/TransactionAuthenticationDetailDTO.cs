using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransactionAuthenticationDetailDTO Data Structure.
    /// </summary>
    public class TransactionAuthenticationDetailDTO : AlipayObject
    {
        /// <summary>
        /// 支付打断推进方式
        /// </summary>
        [JsonPropertyName("authentication_mechanisms")]
        public List<string> AuthenticationMechanisms { get; set; }

        /// <summary>
        /// 密码校验方式
        /// </summary>
        [JsonPropertyName("pin_format")]
        public string PinFormat { get; set; }
    }
}
