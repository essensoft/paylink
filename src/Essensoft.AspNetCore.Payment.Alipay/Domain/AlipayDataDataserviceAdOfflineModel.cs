using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdOfflineModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdOfflineModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonProperty("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 操作的广告层级类型，如计划(plan)，单元(group)，创意 （creative）
        /// </summary>
        [JsonProperty("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放层级的对应的外部资源ID
        /// </summary>
        [JsonProperty("outer_id_list")]
        public List<string> OuterIdList { get; set; }
    }
}
