using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstCashPoolAccountMappingVO Data Structure.
    /// </summary>
    public class InstCashPoolAccountMappingVO : AlipayObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 当前机构账户
        /// </summary>
        [JsonPropertyName("inst_account")]
        public InstAccountDTO InstAccount { get; set; }

        /// <summary>
        /// 当前账号是否为资金池主账号，Y是，N不是
        /// </summary>
        [JsonPropertyName("main_account")]
        public string MainAccount { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父账号
        /// </summary>
        [JsonPropertyName("parent_inst_account")]
        public InstAccountDTO ParentInstAccount { get; set; }
    }
}
