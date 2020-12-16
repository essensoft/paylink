using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAccountBindModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolAccountBindModel : AlipayObject
    {
        /// <summary>
        /// 资金池账户关联关系
        /// </summary>
        [JsonPropertyName("cash_pool_account_mapping_vo_list")]
        public List<InstCashPoolAccountMappingVO> CashPoolAccountMappingVoList { get; set; }

        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
