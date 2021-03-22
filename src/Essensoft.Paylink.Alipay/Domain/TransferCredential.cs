using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferCredential Data Structure.
    /// </summary>
    public class TransferCredential : AlipayObject
    {
        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("credential_no")]
        public string CredentialNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("credential_type")]
        public string CredentialType { get; set; }
    }
}
