using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountBalanceQueryOrder Data Structure.
    /// </summary>
    public class SubAccountBalanceQueryOrder : AlipayObject
    {
        /// <summary>
        /// 子户识别基本信息
        /// </summary>
        [JsonPropertyName("sub_account_base_info")]
        public SubAccountBaseInfo SubAccountBaseInfo { get; set; }
    }
}
