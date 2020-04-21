using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcapiprodDrawndnPaymentscheduleGetResponse.
    /// </summary>
    public class AlipayEcapiprodDrawndnPaymentscheduleGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回的支用还款计划集合
        /// </summary>
        [JsonPropertyName("payment_schedules")]
        public List<PaymentSchedule> PaymentSchedules { get; set; }

        /// <summary>
        /// 唯一标识这次请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
