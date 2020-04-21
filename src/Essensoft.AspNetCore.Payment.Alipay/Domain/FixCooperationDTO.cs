using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FixCooperationDTO Data Structure.
    /// </summary>
    public class FixCooperationDTO : AlipayObject
    {
        /// <summary>
        /// 协作任务的处理结论
        /// </summary>
        [JsonPropertyName("conclusion")]
        public string Conclusion { get; set; }

        /// <summary>
        /// 协作任务的唯一id
        /// </summary>
        [JsonPropertyName("cooperation_id")]
        public long CooperationId { get; set; }

        /// <summary>
        /// 协作任务的处理完成时间。
        /// </summary>
        [JsonPropertyName("deal_time")]
        public string DealTime { get; set; }

        /// <summary>
        /// 协作任务的处理说明
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 实际处理人的名称
        /// </summary>
        [JsonPropertyName("duty_owner_name")]
        public string DutyOwnerName { get; set; }

        /// <summary>
        /// 协作任务的创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 协作任务的处理方公司名
        /// </summary>
        [JsonPropertyName("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 协作任务的处理结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
