using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionCascademissionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionCascademissionCreateModel : AlipayObject
    {
        /// <summary>
        /// 子任务的分佣配置
        /// </summary>
        [JsonProperty("cascade_mission_conf")]
        public List<CascadeMissionConfModel> CascadeMissionConf { get; set; }

        /// <summary>
        /// 根据identify_type指定的值  misison时，为需要设置子任务的分佣任务ID  voucher时，为需要券ID
        /// </summary>
        [JsonProperty("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 主键类型  mission：已经领取的任务，需要在该任务下发布子任务的ID  voucher：任务对应的券ID
        /// </summary>
        [JsonProperty("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
