using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelFliggyAuthorityQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelFliggyAuthorityQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝运营店ID
        /// </summary>
        [JsonPropertyName("global_shop_id")]
        public string GlobalShopId { get; set; }

        /// <summary>
        /// 登录账户的操作员ID
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 用户类型: 主账户 or 操作员. 主账号:MAIN_ACCOUNT 操作员:OPERATOR
        /// </summary>
        [JsonPropertyName("operator_type")]
        public string OperatorType { get; set; }

        /// <summary>
        /// 登录账户归属的机构PID
        /// </summary>
        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 飞猪门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
