using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [JsonProperty("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 扩展信息，请参见产品文档
        /// </summary>
        [JsonProperty("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonProperty("item_order_list")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息  列表最多支持物流信息个数，请参考产品文档  注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [JsonProperty("logistics_info_list")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 签约商户userId
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 卖家userId
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }
    }
}
