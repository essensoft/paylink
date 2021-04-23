using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessMallPointsNotifyModel Data Structure.
    /// </summary>
    public class AlipayBusinessMallPointsNotifyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用于标明此单是否获得积分， true为获得积分， false为未获得
        /// </summary>
        [JsonPropertyName("earn_points")]
        public bool EarnPoints { get; set; }

        /// <summary>
        /// 当未获得积分时，提供未获得积分的原因等备注信息
        /// </summary>
        [JsonPropertyName("no_points_remarks")]
        public string NoPointsRemarks { get; set; }

        /// <summary>
        /// 此单获得积分数
        /// </summary>
        [JsonPropertyName("obtain_points")]
        public long ObtainPoints { get; set; }

        /// <summary>
        /// 此笔订单积分处理成功的时间
        /// </summary>
        [JsonPropertyName("points_update_time")]
        public string PointsUpdateTime { get; set; }

        /// <summary>
        /// 顾客积分总额
        /// </summary>
        [JsonPropertyName("total_points")]
        public long TotalPoints { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
