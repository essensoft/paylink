using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AddPlanGroupResult Data Structure.
    /// </summary>
    [Serializable]
    public class AddPlanGroupResult : AlipayObject
    {
        /// <summary>
        /// 新增计划下单元后，返回的单元ID列表
        /// </summary>
        [JsonProperty("group_id_list")]
        public List<long> GroupIdList { get; set; }

        /// <summary>
        /// 新增计划后计划ID
        /// </summary>
        [JsonProperty("plan_id")]
        public long PlanId { get; set; }
    }
}
