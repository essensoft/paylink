using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineTrade Data Structure.
    /// </summary>
    public class AlipayOfflineTrade : AlipayObject
    {
        /// <summary>
        /// 交易实际发生时间
        /// </summary>
        [JsonPropertyName("actual_order_time")]
        public string ActualOrderTime { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易对应的卡类型。
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 交易扩展信息,json格式字符串。
        /// </summary>
        [JsonPropertyName("order_biz_context")]
        public string OrderBizContext { get; set; }

        /// <summary>
        /// 支付宝外部交易号，唯一表示一笔商户支付宝交易。商户必须保证唯一。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 原始脱机操作记录
        /// </summary>
        [JsonPropertyName("records")]
        public List<string> Records { get; set; }

        /// <summary>
        /// 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        [JsonPropertyName("seller_login_name")]
        public string SellerLoginName { get; set; }

        /// <summary>
        /// 脱机交易标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
