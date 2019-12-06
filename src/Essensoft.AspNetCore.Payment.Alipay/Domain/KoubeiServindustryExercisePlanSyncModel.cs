using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExercisePlanSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExercisePlanSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据版本号。linux时间戳，到毫秒级别。如果同步数据的版本号小于口碑服务器已有数据的版本号，则会被丢弃。
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 口碑用户健身通行证ID，和用户ID一一对应
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 健身计划列表
        /// </summary>
        [JsonPropertyName("plan_list")]
        public List<ExercisePlanOpenModel> PlanList { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
