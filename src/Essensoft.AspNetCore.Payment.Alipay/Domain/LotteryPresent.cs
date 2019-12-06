using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LotteryPresent Data Structure.
    /// </summary>
    public class LotteryPresent : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 彩种名称
        /// </summary>
        [JsonPropertyName("lottery_type_name")]
        public string LotteryTypeName { get; set; }

        /// <summary>
        /// 赠送时间，格式yyyy-MM-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("present_date")]
        public string PresentDate { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("present_id")]
        public long PresentId { get; set; }

        /// <summary>
        /// 彩票注数
        /// </summary>
        [JsonPropertyName("stake_count")]
        public long StakeCount { get; set; }

        /// <summary>
        /// 订单状态，含义如下：0-卖家资金未冻结;1-买家未领取;2-买家己领取;3-己创建彩票订单;4-彩票订单出票成功;5-资金己转交代理商;6-订单己过期，待退款;7-冻结资金己退款;8-订单取消。
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 订单状态描述，参见status描述。
        /// </summary>
        [JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 赠言，不超过20个汉字
        /// </summary>
        [JsonPropertyName("sweety_words")]
        public string SweetyWords { get; set; }

        /// <summary>
        /// 中奖金额，单位：分，为0表示未中奖
        /// </summary>
        [JsonPropertyName("win_fee")]
        public long WinFee { get; set; }
    }
}
