using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationAuthAddModel Data Structure.
    /// </summary>
    public class AlipayOpenSpOperationAuthAddModel : AlipayObject
    {
        /// <summary>
        /// 授权产品码，零售通填写KX_ECOLOGY_SOLUTION
        /// </summary>
        [JsonPropertyName("auth_product_code")]
        public string AuthProductCode { get; set; }

        /// <summary>
        /// 直连商户PID
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 外部操作流水，ISV自定义。每次操作需要确保唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
