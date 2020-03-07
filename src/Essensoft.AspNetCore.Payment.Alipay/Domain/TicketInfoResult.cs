using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TicketInfoResult Data Structure.
    /// </summary>
    public class TicketInfoResult : AlipayObject
    {
        /// <summary>
        /// 地址 不同类型下的地址含义不同。若type为MEAL_NUM，address则代表取餐地点；若type为PICKUP_CODE，address则代表取件地点。其他类型查看小程序订单产品文档
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 单据号 不同类型下单据号含义不同。若类型为MEAL_NUM，则ticket_no表示取餐号；若类型为PICKUP_CODE，则ticket_no表示取件码；其他类型查看小程序订单产品文档
        /// </summary>
        [JsonPropertyName("ticket_no")]
        public string TicketNo { get; set; }

        /// <summary>
        /// 时间 不同类型下的地址含义不同。若type为MEAL_NUM，time则代表取餐时间；若type为PICKUP_CODE，address则代表取件时间。其他类型查看小程序订单产品文档
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 凭证类型 MEAL_NUM：取餐号 PICKUP_CODE：取件号 具体类型查看产品文档
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
