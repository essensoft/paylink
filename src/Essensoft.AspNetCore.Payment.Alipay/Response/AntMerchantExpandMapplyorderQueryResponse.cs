using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandMapplyorderQueryResponse.
    /// </summary>
    public class AntMerchantExpandMapplyorderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部入驻申请单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 入驻申请单认证审核、签约审核详情
        /// </summary>
        [JsonPropertyName("result_info")]
        public List<MerchantApplyResultRecord> ResultInfo { get; set; }
    }
}
