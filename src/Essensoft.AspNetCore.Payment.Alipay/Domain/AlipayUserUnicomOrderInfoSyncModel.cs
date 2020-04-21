using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserUnicomOrderInfoSyncModel Data Structure.
    /// </summary>
    public class AlipayUserUnicomOrderInfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单变更时间，返回自January 1, 1970, 00:00:00 GMT至订单变更时刻的毫秒数, java代码获取示例：new Date().getTime()
        /// </summary>
        [JsonPropertyName("gmt_order_change")]
        public string GmtOrderChange { get; set; }

        /// <summary>
        /// 用户在联通开卡创建的订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单变更类型，包括创建(ORDER_CREATE)、撤销(ORDER_CANCEL)、支付(ORDER_PAID)等
        /// </summary>
        [JsonPropertyName("order_operate_type")]
        public string OrderOperateType { get; set; }

        /// <summary>
        /// 用户在创建开卡订单时选择的联通号码（11位，不带国家码）
        /// </summary>
        [JsonPropertyName("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 联通资费产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 参数校验值
        /// </summary>
        [JsonPropertyName("sec_key")]
        public string SecKey { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
