using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueOrderConfirmModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVenueOrderConfirmModel : AlipayObject
    {
        /// <summary>
        /// 订单确认描述
        /// </summary>
        [JsonPropertyName("confirm_desc")]
        public string ConfirmDesc { get; set; }

        /// <summary>
        /// 订单确认状态 succ - 确认成功 fail - 确认失败
        /// </summary>
        [JsonPropertyName("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 支付宝业务订单唯一ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务商内部唯一订单号
        /// </summary>
        [JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 订单商品信息列表
        /// </summary>
        [JsonPropertyName("product_group_list")]
        public List<ProductGroup> ProductGroupList { get; set; }

        /// <summary>
        /// 订单付款总金额(单位：元)
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
