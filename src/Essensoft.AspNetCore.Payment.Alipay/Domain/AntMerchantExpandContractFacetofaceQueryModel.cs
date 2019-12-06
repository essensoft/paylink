using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandContractFacetofaceQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandContractFacetofaceQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝端商户入驻申请单据号，通过调用ant.merchant.expand.contract.facetoface.sign接口返回的参数中获取
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部入驻申请单据号，必须跟ant.merchant.expand.contract.facetoface.sign中的out_biz_no值保持一致
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
