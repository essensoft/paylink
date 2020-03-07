using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceItaskProcessDetailModifyResponse.
    /// </summary>
    public class AlipayIserviceItaskProcessDetailModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 蚂蚁工单编号
        /// </summary>
        [JsonPropertyName("alipay_process_id")]
        public string AlipayProcessId { get; set; }

        /// <summary>
        /// 工单处理状态，枚举（CREATED，PROCESSING，COMPLETED，CANCELED）
        /// </summary>
        [JsonPropertyName("alipay_process_status")]
        public string AlipayProcessStatus { get; set; }

        /// <summary>
        /// 外部工单业务扩展字段，业务属性信息都放置在此字段。最多10个字段。
        /// </summary>
        [JsonPropertyName("extend_field_infos")]
        public List<ExtendFieldInfo> ExtendFieldInfos { get; set; }
    }
}
