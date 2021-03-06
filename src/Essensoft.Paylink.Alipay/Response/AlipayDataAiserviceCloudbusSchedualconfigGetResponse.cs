﻿using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigGetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleConfigGetResult Result { get; set; }
    }
}
