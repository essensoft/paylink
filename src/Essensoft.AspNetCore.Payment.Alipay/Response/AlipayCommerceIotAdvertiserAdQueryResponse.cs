using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdQueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 定向的设备sn列表
        /// </summary>
        [JsonPropertyName("device_sn_list")]
        public List<string> DeviceSnList { get; set; }

        /// <summary>
        /// 投放结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 投放的物料地址
        /// </summary>
        [JsonPropertyName("material_url")]
        public string MaterialUrl { get; set; }

        /// <summary>
        /// 投放计划名称
        /// </summary>
        [JsonPropertyName("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 计划状态(异常、生效、待生效、结束、审核中、已取消、投放错误、审核不通过)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
