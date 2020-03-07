using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandTradeorderSyncModel Data Structure.
    /// </summary>
    public class AntMerchantExpandTradeorderSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单金额（单位：分）
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 买家的支付宝账号对应的支付宝唯一用户号（以2088开头的纯16位数字）
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 扩展信息（键值对列表，有重复的键后者覆盖前者，建议唯一，以免出现不可预期的结果）
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品订单列表
        /// </summary>
        [JsonPropertyName("item_order_list")]
        public List<ItemOrder> ItemOrderList { get; set; }

        /// <summary>
        /// 备注信息，一万个字符以内
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商家补贴金额（单位：分）
        /// </summary>
        [JsonPropertyName("merchant_subsidy_amount")]
        public long MerchantSubsidyAmount { get; set; }

        /// <summary>
        /// 服务商、平台商侧自己的业务订单单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型，由大写字母以及下划线组成，由支付宝分配
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部商户优惠信息列表
        /// </summary>
        [JsonPropertyName("out_discount_infos")]
        public List<OutDiscountInfo> OutDiscountInfos { get; set; }

        /// <summary>
        /// 服务商、平台商在支付宝侧的商户id
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 平台补贴金额（单位：分）
        /// </summary>
        [JsonPropertyName("partner_subsidy_amount")]
        public long PartnerSubsidyAmount { get; set; }

        /// <summary>
        /// 实付金额（单位：分）
        /// </summary>
        [JsonPropertyName("real_amount")]
        public long RealAmount { get; set; }

        /// <summary>
        /// 卖家的支付宝账号对应的支付宝唯一用户号（以2088开头的纯16位数字）
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 蚂蚁门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
