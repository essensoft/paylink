using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeAdvanceConsultResponse.
    /// </summary>
    public class AlipayTradeAdvanceConsultResponse : AlipayResponse
    {
        /// <summary>
        /// true 代表当前时间点，用户允许垫资 false 代表当前时间，用户不允许垫资
        /// </summary>
        [JsonPropertyName("refer_result")]
        public bool ReferResult { get; set; }

        /// <summary>
        /// 用户被注销
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回用户不准入原因
        /// </summary>
        [JsonPropertyName("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 订单风险评估等级，在单笔订单风险预评估时返回。当基础风险校验通过时，可通过该值获取业务风险评估等级。取值：2-高风险；1-低风险。
        /// </summary>
        [JsonPropertyName("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 用户剩余的总待还金额，无论当前用户是否允许垫资，都会返回改属性
        /// </summary>
        [JsonPropertyName("wait_repayment_amount")]
        public string WaitRepaymentAmount { get; set; }

        /// <summary>
        /// 用户总的未还的垫资笔数，无论用户是否允许垫资，都会返回该属性
        /// </summary>
        [JsonPropertyName("wait_repayment_order_count")]
        public long WaitRepaymentOrderCount { get; set; }

        /// <summary>
        /// 待还订单列表，无论用户当前状态是否允许垫资，都会返回当前用户在商户下的待还订单信息
        /// </summary>
        [JsonPropertyName("wait_repayment_order_infos")]
        public List<WaitRepaymentOrderInfo> WaitRepaymentOrderInfos { get; set; }
    }
}
