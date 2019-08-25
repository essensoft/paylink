using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDetailChannelModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDetailChannelModel : AlipayObject
    {
        /// <summary>
        /// 渠道id
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 查询时间段内的推广数据
        /// </summary>
        [JsonProperty("part_promote_data")]
        public PromoteDataModel PartPromoteData { get; set; }

        /// <summary>
        /// 总推广数据
        /// </summary>
        [JsonProperty("total_promote_data")]
        public PromoteDataModel TotalPromoteData { get; set; }
    }
}
