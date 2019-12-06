using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccPayeeInfo Data Structure.
    /// </summary>
    public class AccPayeeInfo : AlipayObject
    {
        /// <summary>
        /// 收款方电子钱包账号。
        /// </summary>
        [JsonPropertyName("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 收款方电子钱包持有者姓名。
        /// </summary>
        [JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }
    }
}
