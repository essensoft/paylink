using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDetailChannelModel Data Structure.
    /// </summary>
    public class PromoteDetailChannelModel : AlipayObject
    {
        /// <summary>
        /// 渠道id
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 查询时间段内的推广数据
        /// </summary>
        [JsonPropertyName("part_promote_data")]
        public PromoteDataModel PartPromoteData { get; set; }

        /// <summary>
        /// 总推广数据
        /// </summary>
        [JsonPropertyName("total_promote_data")]
        public PromoteDataModel TotalPromoteData { get; set; }
    }
}
