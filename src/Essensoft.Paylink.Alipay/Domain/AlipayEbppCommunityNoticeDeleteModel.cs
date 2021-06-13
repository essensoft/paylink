using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppCommunityNoticeDeleteModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityNoticeDeleteModel : AlipayObject
    {
        /// <summary>
        /// 支付宝公告id
        /// </summary>
        [JsonPropertyName("alipay_notice_id")]
        public long AlipayNoticeId { get; set; }

        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
