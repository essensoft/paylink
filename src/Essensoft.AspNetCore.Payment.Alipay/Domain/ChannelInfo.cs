using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ChannelInfo Data Structure.
    /// </summary>
    public class ChannelInfo : AlipayObject
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
        /// 资产详情扩展参数
        /// </summary>
        [JsonPropertyName("assets_detail_params")]
        public AssetsDetailParams AssetsDetailParams { get; set; }

        /// <summary>
        /// 渠道可用额度
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 渠道不可用错误码
        /// </summary>
        [JsonPropertyName("close_error_code")]
        public string CloseErrorCode { get; set; }

        /// <summary>
        /// 渠道不可用原因
        /// </summary>
        [JsonPropertyName("close_error_msg")]
        public string CloseErrorMsg { get; set; }

        /// <summary>
        /// 渠道索引
        /// </summary>
        [JsonPropertyName("compatible_channel_index")]
        public string CompatibleChannelIndex { get; set; }

        /// <summary>
        /// 渠道是否可用
        /// </summary>
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 渠道是否足额
        /// </summary>
        [JsonPropertyName("enough")]
        public bool Enough { get; set; }

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
        /// 资产名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 推荐文案
        /// </summary>
        [JsonPropertyName("recommend_text")]
        public string RecommendText { get; set; }

        /// <summary>
        /// 推荐提示文案
        /// </summary>
        [JsonPropertyName("recommend_tip")]
        public string RecommendTip { get; set; }

        /// <summary>
        /// 渠道是否已签约
        /// </summary>
        [JsonPropertyName("signed")]
        public bool Signed { get; set; }
    }
}
