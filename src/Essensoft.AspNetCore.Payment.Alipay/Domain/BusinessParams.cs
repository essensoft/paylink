using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessParams Data Structure.
    /// </summary>
    public class BusinessParams : AlipayObject
    {
        /// <summary>
        /// 实际订单时间，在乘车码场景，传入的是用户刷码乘车时间
        /// </summary>
        [JsonPropertyName("actual_order_time")]
        public string ActualOrderTime { get; set; }

        /// <summary>
        /// 校园卡编号
        /// </summary>
        [JsonPropertyName("campus_card")]
        public string CampusCard { get; set; }

        /// <summary>
        /// 虚拟卡卡类型
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }
    }
}
