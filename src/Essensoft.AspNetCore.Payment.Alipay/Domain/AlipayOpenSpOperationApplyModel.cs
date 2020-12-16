using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenSpOperationApplyModel : AlipayObject
    {
        /// <summary>
        /// 接入的产品编号。 枚举如下： 操作类型为账号绑定时，填OPENAPI_BIND_DEFAULT。 操作类型为代运营授权时，填OPENAPI_AUTH_DEFAULT。
        /// </summary>
        [JsonPropertyName("access_product_code")]
        public string AccessProductCode { get; set; }

        /// <summary>
        /// 支付宝登录账号。通常为手机号或者邮箱。 若被代运营者是间连商户，则alipay_account必填。 若为直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 支付宝商户号。间连、直连商户均支持，特别注意仅支持2088开头的间连商户。 若被代运营者是间连商户，则merchant_no必填。 若为直连商户，则merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 代运营操作类型。取值如下： ACCOUNT_BIND：账号绑定，仅对于间连商户。 OPERATION_AUTH：代运营授权，支持间连及直连商户。
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部操作流水，ISV自定义。每次操作需要确保唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
