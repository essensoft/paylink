using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeApplepayAuthenticationSubmitModel Data Structure.
    /// </summary>
    public class AlipayTradeApplepayAuthenticationSubmitModel : AlipayObject
    {
        /// <summary>
        /// ApplePay核身鉴权结果，包括：支付密码、用户确认、数字签名
        /// </summary>
        [JsonPropertyName("authentication_results")]
        public List<AuthenticationResult> AuthenticationResults { get; set; }

        /// <summary>
        /// Apple端的设备ID
        /// </summary>
        [JsonPropertyName("device_identifier")]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// Apple绑定的BundleId
        /// </summary>
        [JsonPropertyName("dpan_identifier")]
        public string DpanIdentifier { get; set; }

        /// <summary>
        /// 交易标识
        /// </summary>
        [JsonPropertyName("transaction_identifier")]
        public string TransactionIdentifier { get; set; }
    }
}
