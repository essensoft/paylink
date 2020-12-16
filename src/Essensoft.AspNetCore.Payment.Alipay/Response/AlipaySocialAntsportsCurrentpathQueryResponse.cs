using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialAntsportsCurrentpathQueryResponse.
    /// </summary>
    public class AlipaySocialAntsportsCurrentpathQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 运动数据今日已消费步数
        /// </summary>
        [JsonPropertyName("exercise_consume_step_count")]
        public long ExerciseConsumeStepCount { get; set; }

        /// <summary>
        /// 运动数据今日行走步数
        /// </summary>
        [JsonPropertyName("exercise_produce_step_count")]
        public long ExerciseProduceStepCount { get; set; }

        /// <summary>
        /// 用户路线参当前路线已走步数
        /// </summary>
        [JsonPropertyName("forward_step_count")]
        public long ForwardStepCount { get; set; }

        /// <summary>
        /// 最小起go步数
        /// </summary>
        [JsonPropertyName("min_go_steps")]
        public long MinGoSteps { get; set; }

        /// <summary>
        /// 下一个路线ID
        /// </summary>
        [JsonPropertyName("next_unlock_path_id")]
        public string NextUnlockPathId { get; set; }

        /// <summary>
        /// 路线完成状态
        /// </summary>
        [JsonPropertyName("path_complete_status")]
        public string PathCompleteStatus { get; set; }

        /// <summary>
        /// 路线ID
        /// </summary>
        [JsonPropertyName("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 路线加入状态
        /// </summary>
        [JsonPropertyName("path_join_status")]
        public string PathJoinStatus { get; set; }

        /// <summary>
        /// 路线名称
        /// </summary>
        [JsonPropertyName("path_name")]
        public string PathName { get; set; }

        /// <summary>
        /// 加入路线的流水
        /// </summary>
        [JsonPropertyName("path_record_id")]
        public string PathRecordId { get; set; }

        /// <summary>
        /// 当前行走的路线场景
        /// </summary>
        [JsonPropertyName("path_scene")]
        public string PathScene { get; set; }

        /// <summary>
        /// 路线归属站点编码
        /// </summary>
        [JsonPropertyName("path_station_code")]
        public string PathStationCode { get; set; }

        /// <summary>
        /// 路线归属站点名称
        /// </summary>
        [JsonPropertyName("path_station_name")]
        public string PathStationName { get; set; }
    }
}
