using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyQrcodeInvalidDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyQrcodeInvalidDeleteModel : AlipayObject
    {
        /// <summary>
        /// 需要失效的二维码的加密 token 信息
        /// </summary>
        [JsonProperty("encrypt_token")]
        public string EncryptToken { get; set; }
    }
}
