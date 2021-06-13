using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTransferBalanceQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTransferBalanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 账户别名
        /// </summary>
        [JsonPropertyName("account_alias")]
        public string AccountAlias { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
