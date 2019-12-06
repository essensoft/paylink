using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GoodsReturnOrder Data Structure.
    /// </summary>
    public class GoodsReturnOrder : AlipayObject
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// 退货单类型
        /// </summary>
        [JsonPropertyName("erp_order_type")]
        public string ErpOrderType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 退货明细
        /// </summary>
        [JsonPropertyName("order_item")]
        public List<GoodsReturnOrderItem> OrderItem { get; set; }

        /// <summary>
        /// 退货单关联的原erpOrder单据
        /// </summary>
        [JsonPropertyName("ori_erp_order")]
        public string OriErpOrder { get; set; }

        /// <summary>
        /// 退货单关联的原erpOrder类型
        /// </summary>
        [JsonPropertyName("ori_erp_order_type")]
        public string OriErpOrderType { get; set; }
    }
}
