using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundJointaccountBillQueryResponse.
    /// </summary>
    public class AlipayFundJointaccountBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回账单列表
        /// </summary>
        [JsonPropertyName("bill_list")]
        public List<JointAccountBillDetailDTO> BillList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_next_page")]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当期页数
        /// </summary>
        [JsonPropertyName("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当期页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
