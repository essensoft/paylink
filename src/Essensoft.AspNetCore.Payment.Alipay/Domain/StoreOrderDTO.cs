using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StoreOrderDTO Data Structure.
    /// </summary>
    public class StoreOrderDTO : AlipayObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 业务场景对应的扩展字段
        /// </summary>
        [JsonPropertyName("ext")]
        public List<OrderExt> Ext { get; set; }

        /// <summary>
        /// 订单相关的商品信息
        /// </summary>
        [JsonPropertyName("goods_info_list")]
        public List<StoreOrderGood> GoodsInfoList { get; set; }

        /// <summary>
        /// 订单的描述
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单的ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
