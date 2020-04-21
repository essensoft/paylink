using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseRecordSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExerciseRecordSyncModel : AlipayObject
    {
        /// <summary>
        /// 数据版本号。linux时间戳，到毫秒级别。如果同步数据的版本号小于口碑服务器已有数据的版本号，则会被丢弃。
        /// </summary>
        [JsonPropertyName("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 口碑用户健身唯一ID，和支付宝userId一一对应
        /// </summary>
        [JsonPropertyName("fitness_id")]
        public string FitnessId { get; set; }

        /// <summary>
        /// 健身记录列表，每个记录是一天的全量记录
        /// </summary>
        [JsonPropertyName("record_list")]
        public List<ExerciseRecordOpenModel> RecordList { get; set; }

        /// <summary>
        /// 口碑店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
