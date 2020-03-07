using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBuyerCreditApplyModel Data Structure.
    /// </summary>
    public class AlipayTradeBuyerCreditApplyModel : AlipayObject
    {
        /// <summary>
        /// 标识买家授信额度的来源
        /// </summary>
        [JsonPropertyName("buyer_credit_source")]
        public string BuyerCreditSource { get; set; }

        /// <summary>
        /// 本次授信拆分的买家主体userId
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 卖家给买家分配的信用赊账周期，在账期结束前需要还款完成。取值格式：1m(表示分钟)，2h(表示小时)，3d(表示天)
        /// </summary>
        [JsonPropertyName("credit_period")]
        public string CreditPeriod { get; set; }

        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [JsonPropertyName("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 卖家授信拆分给买家的额度  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("grant_credit_quota")]
        public string GrantCreditQuota { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [JsonPropertyName("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 商家授权开通账期的卖家userid
        /// </summary>
        [JsonPropertyName("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 标识授信操作的类型。  CREATE_CREDIT(创建授信)  MODIFY_CREDIT(修改授信)  CLOSE_CREDIT(关闭授信)
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 卖家每次发起授权拆分对应一次外部请求号，用于幂等使用
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次操作前未拆分的的授信额度  单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("previous_credit_quota")]
        public string PreviousCreditQuota { get; set; }
    }
}
