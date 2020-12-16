using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderInfoDTO Data Structure.
    /// </summary>
    public class OrderInfoDTO : AlipayObject
    {
        /// <summary>
        /// 支付宝平台接收开通门店码请求后分配的流水编号
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 流水创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 服务商操作人ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 外部业务流水号，由服务商生成，作为请求的外部主键
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户PID，本次开通门店码的商家PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 外部业务流水号，由服务商生成，作为请求的外部主键。(已废弃，建议使用out_biz_no字段)
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 开通结果状态码，具体如下： WAIT_MERCHANT_CONFIRM - 等待商户确认； AUDIT_PASSED - 审核通过； AUDIT_FAILED - 审核不通过；
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 开通结果状态描述，对应result_code状态码字段，如下： WAIT_MERCHANT_CONFIRM - 等待商户确认； AUDIT_PASSED - 审核通过； AUDIT_FAILED - 审核不通过；
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 支付宝门店ID，门店进件后生成
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 开通状态，状态码如下： - NOT_OPEN  未开通 - OPENING  开通中 - OPENED  已开通
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店开通码子状态，仅在开通中状态(OPENING)才有子状态分类： - WAIT_CONFIRM  待商家确认 - AUDIT_SUBMITTED  商家已确认，平台审核中 - AUDIT_PASSED  审核通过 - AUDIT_FAILED  审核失败
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }
    }
}
