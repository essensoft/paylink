using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSpOperationApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenSpOperationApplyModel : AlipayObject
    {
        /// <summary>
        /// 接入的产品编号。 枚举如下： * OPENAPI_BIND_DEFAULT：操作类型为账号绑定。 * OPENAPI_AUTH_DEFAULT：操作类型为代运营授权时。
        /// </summary>
        [JsonPropertyName("access_product_code")]
        public string AccessProductCode { get; set; }

        /// <summary>
        /// 支付宝登录账号，通常为手机号或者邮箱。 间连场景必填。 直连场景选填，特别注意merchant_no和alipay_account不能同时为空，都有值优先取merchant_no。
        /// </summary>
        [JsonPropertyName("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 支付宝商户号。 间连场景，merchant_no必填，传入商户smid，特别注意仅支持2088开头的间连商户。 直连场景，merchant_no选填，传入商户支付宝pid，特别注意merchant_no和alipay_account不能同时为空，优先取merchant_no。
        /// </summary>
        [JsonPropertyName("merchant_no")]
        public string MerchantNo { get; set; }

        /// <summary>
        /// 代运营操作类型。枚举如下： * ACCOUNT_BIND：代表绑定支付宝账号，仅对于间连商户。 * OPERATION_AUTH：代表代运营授权，支持间连和直连商户，其中间连场景包含绑定支付宝账号。
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
