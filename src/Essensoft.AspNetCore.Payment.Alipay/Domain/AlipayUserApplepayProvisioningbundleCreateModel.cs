using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleCreateModel Data Structure.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("alipay_user_identifier")]
        public string AlipayUserIdentifier { get; set; }
    }
}
