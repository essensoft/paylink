using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeBuyerCreditConfirmResponse.
    /// </summary>
    public class AlipayTradeBuyerCreditConfirmResponse : AlipayResponse
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
        /// 本次授信拆分的操作明细单号，每一次授信申请或者关闭会生成唯一个单号
        /// </summary>
        [JsonPropertyName("grant_operation_no")]
        public string GrantOperationNo { get; set; }

        /// <summary>
        /// 标识本次授信拆分的状态  INIT: 申请中  SUCCESS：已确认  CLOSE: 已撤销
        /// </summary>
        [JsonPropertyName("grant_status")]
        public string GrantStatus { get; set; }

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
    }
}
