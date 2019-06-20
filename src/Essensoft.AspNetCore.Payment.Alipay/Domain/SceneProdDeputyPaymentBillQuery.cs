using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneProdDeputyPaymentBillQuery Data Structure.
    /// </summary>
    [Serializable]
    public class SceneProdDeputyPaymentBillQuery : AlipayObject
    {
        /// <summary>
        /// 代客还款的网商银行结算户信息
        /// </summary>
        [JsonProperty("deputy_account")]
        public string DeputyAccount { get; set; }

        /// <summary>
        /// 代客还款状态，VALID 代客还款， INVALID 取消代客还款，USING代客还款中，USED已代客还款
        /// </summary>
        [JsonProperty("deputy_status")]
        public string DeputyStatus { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [JsonProperty("term")]
        public string Term { get; set; }
    }
}
