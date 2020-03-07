using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailCreateResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [JsonPropertyName("alipay_process_id")]
        public string AlipayProcessId { get; set; }

        /// <summary>
        /// 工单处理状态，枚举值（CREATED，PROCESSING，COMPLETED，CANCELED）
        /// </summary>
        [JsonPropertyName("alipay_process_status")]
        public string AlipayProcessStatus { get; set; }

        /// <summary>
        /// 工单响应扩展信息，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [JsonPropertyName("extend_field_infos")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }

        /// <summary>
        /// 工单信息唯一标识ID，简写为puid。为app_name、process_no和alipay_process_id共同组合而成，供工单推进接口使用。
        /// </summary>
        [JsonPropertyName("process_unique_id")]
        public string ProcessUniqueId { get; set; }
    }
}
