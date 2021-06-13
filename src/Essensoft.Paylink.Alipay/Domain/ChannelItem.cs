using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ChannelItem Data Structure.
    /// </summary>
    public class ChannelItem : AlipayObject
    {
        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonPropertyName("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产编码
        /// </summary>
        [JsonPropertyName("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 渠道索引
        /// </summary>
        [JsonPropertyName("channel_index")]
        public string ChannelIndex { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 渠道logo图片的url地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 渠道运营文案
        /// </summary>
        [JsonPropertyName("recommend_tip")]
        public string RecommendTip { get; set; }
    }
}
