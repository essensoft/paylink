using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDetailModel : AlipayObject
    {
        /// <summary>
        /// 广告id
        /// </summary>
        [JsonProperty("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 标的业务id
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型（目前只支持ITEM）
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 推广标的商品信息
        /// </summary>
        [JsonProperty("item_info")]
        public PromoteItemModel ItemInfo { get; set; }

        /// <summary>
        /// 推广数据
        /// </summary>
        [JsonProperty("promote_data")]
        public PromoteDataModel PromoteData { get; set; }
    }
}
