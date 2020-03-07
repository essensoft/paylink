using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeBillListQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeBillListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单详细信息
        /// </summary>
        [JsonPropertyName("bill_detail_list")]
        public BillDetailVo BillDetailList { get; set; }

        /// <summary>
        /// 是否有下一页，false表示已经到最后一页了
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前页面条数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 不可见不可用信息
        /// </summary>
        [JsonPropertyName("refuse_msg")]
        public RefuseVo RefuseMsg { get; set; }

        /// <summary>
        /// 标识本次请求是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
