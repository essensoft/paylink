using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainScrelationModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainScrelationModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [JsonPropertyName("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 支付宝内部店铺id列表
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
