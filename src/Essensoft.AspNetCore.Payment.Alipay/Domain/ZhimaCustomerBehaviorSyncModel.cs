using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerBehaviorSyncModel Data Structure.
    /// </summary>
    public class ZhimaCustomerBehaviorSyncModel : AlipayObject
    {
        /// <summary>
        /// 反馈行为
        /// </summary>
        [JsonPropertyName("behavior")]
        public List<string> Behavior { get; set; }

        /// <summary>
        /// 行为所携带的内容,fulfillment:{"subjectDeltaNum":"1","subjectType":"subject"}
        /// </summary>
        [JsonPropertyName("behavior_content")]
        public string BehaviorContent { get; set; }

        /// <summary>
        /// 约定编号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 主体类型B或者C
        /// </summary>
        [JsonPropertyName("principal_type")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// 芝麻信用service_id,由芝麻信用提供
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 芝麻信用service_id,由芝麻信用提供
        /// </summary>
        [JsonPropertyName("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 外部订单号，商户请求的唯一标志，64位长度的字母数字下划线组合。该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
