using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDetailModel Data Structure.
    /// </summary>
    public class PromoteDetailModel : AlipayObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 标的业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型（目前只支持ITEM）
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 推广标的商品信息
        /// </summary>
        [JsonPropertyName("item_info")]
        public PromoteItemModel ItemInfo { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [JsonPropertyName("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}
