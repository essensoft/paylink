using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncSubaccountAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 子户信息查询请求
        /// </summary>
        [JsonPropertyName("sub_account_info_query_order")]
        public SubAccountInfoQueryOrder SubAccountInfoQueryOrder { get; set; }
    }
}
