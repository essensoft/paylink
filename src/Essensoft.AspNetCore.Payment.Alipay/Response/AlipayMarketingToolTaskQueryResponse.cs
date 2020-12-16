using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolTaskQueryResponse.
    /// </summary>
    public class AlipayMarketingToolTaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 方案下的任务列表。
        /// </summary>
        [JsonPropertyName("task_list")]
        public List<AppletTaskVO> TaskList { get; set; }
    }
}
