using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransAppMergeConfirmResponse.
    /// </summary>
    public class AlipayFundTransAppMergeConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 合并付款单据号
        /// </summary>
        [JsonPropertyName("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 转账结果列表。会列出该笔合并支付中所有的明细转账结果、状态基础信息。如果需要详情信息，请再请求单笔查询接口进行查询。
        /// </summary>
        [JsonPropertyName("trans_order_results")]
        public List<TransOrderResult> TransOrderResults { get; set; }
    }
}
