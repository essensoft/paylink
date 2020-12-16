using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UpdatedAuthenticationDetails Data Structure.
    /// </summary>
    public class UpdatedAuthenticationDetails : AlipayObject
    {
        /// <summary>
        /// 鉴权机制
        /// </summary>
        [JsonPropertyName("authentication_mechanisms")]
        public List<string> AuthenticationMechanisms { get; set; }

        /// <summary>
        /// 随机数
        /// </summary>
        [JsonPropertyName("nonce")]
        public string Nonce { get; set; }

        /// <summary>
        /// 交易签名信息
        /// </summary>
        [JsonPropertyName("partial_transaction_details_signature")]
        public string PartialTransactionDetailsSignature { get; set; }

        /// <summary>
        /// 6位密码或者长密码
        /// </summary>
        [JsonPropertyName("pin_format")]
        public string PinFormat { get; set; }

        /// <summary>
        /// 签名秘钥
        /// </summary>
        [JsonPropertyName("signing_key_material")]
        public string SigningKeyMaterial { get; set; }
    }
}
