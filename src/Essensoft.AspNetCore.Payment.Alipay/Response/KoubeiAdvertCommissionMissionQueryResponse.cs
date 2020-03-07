using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionQueryResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分佣任务信息  该列表中的任务为已经创建成功的任务，并处于EFFECTIVE或者INVALID状态
        /// </summary>
        [JsonPropertyName("data")]
        public List<KbAdvertMissionQueryResponse> Data { get; set; }

        /// <summary>
        /// 创建处理中任务信息  1、只有待确认的任务（服务商代创建任务），才会出现在该列表中，如果已经确认，则在任务列表data中   2、处理中任务只返回任务状态，以及identify（用于查找任务）  3、由于未创建任务，因此不分配任务ID
        /// </summary>
        [JsonPropertyName("processing_data")]
        public KbAdvertProcessMissionResponse ProcessingData { get; set; }
    }
}
