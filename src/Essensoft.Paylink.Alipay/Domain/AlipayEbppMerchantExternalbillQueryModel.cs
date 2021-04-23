using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppMerchantExternalbillQueryModel : AlipayObject
    {
        /// <summary>
        /// 小区短名, 小区创建时生成
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 页码数
        /// </summary>
        [JsonPropertyName("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页条数（最大200，默认100）
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 支付宝房间id
        /// </summary>
        [JsonPropertyName("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 账单状态： INIT(待缴)，WAIT_PAY(处理中)，FINISH_PAY(已缴)，FAIL(支付失败)，REFUND(异常退款)，INVALID(失效)，CHANNEL_FINISH_PAY（外部渠道支付）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
