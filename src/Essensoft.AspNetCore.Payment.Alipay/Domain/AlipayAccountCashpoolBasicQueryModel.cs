using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolBasicQueryModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolBasicQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询条件，资金池名称，不支持模糊查询
        /// </summary>
        [JsonPropertyName("cash_pool_name")]
        public string CashPoolName { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
