using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandContractFacetofaceQueryResponse.
    /// </summary>
    public class AntMerchantExpandContractFacetofaceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 产品签约审核结果，申请单状态为审核失败时失败原因用“;”分割，其他状态产品签约审核结果为空
        /// </summary>
        [JsonPropertyName("order_detail")]
        public string OrderDetail { get; set; }

        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态，申请单状态包括：暂存、审核中、审核成功、审核失败
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
