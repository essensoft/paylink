using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerFulfillmentSyncModel Data Structure.
    /// </summary>
    public class ZhimaCustomerFulfillmentSyncModel : AlipayObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 芝麻信用service_id,由芝麻信用提供
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 标的变化值
        /// </summary>
        [JsonPropertyName("subject_delta_num")]
        public string SubjectDeltaNum { get; set; }

        /// <summary>
        /// 标的ID，比如淘票票场景标识电影ID，公益场景则标识某种类型公益，判断约定内容是否完成均在此标的ID上做计算，若不传则系统取默认配置值
        /// </summary>
        [JsonPropertyName("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 标的类型枚举，TIMES(次数)/AMT(金额)
        /// </summary>
        [JsonPropertyName("subject_type")]
        public string SubjectType { get; set; }

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
