using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallScanpurchaseTradePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMallScanpurchaseTradePayModel : AlipayObject
    {
        /// <summary>
        /// 预订单编号
        /// </summary>
        [JsonProperty("advance_order_id")]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 买家的支付宝用户id，如果为空，会从传入了码值信息中获取买家ID
        /// </summary>
        [JsonProperty("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 优惠信息
        /// </summary>
        [JsonProperty("discount_details")]
        public List<MallDiscountDetail> DiscountDetails { get; set; }

        /// <summary>
        /// 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。   如果该值未传入，但传入了【订单付款总金额】和【不可打折金额】，则该值默认为【订单付款总金额】-【不可打折金额】
        /// </summary>
        [JsonProperty("discountable_amount")]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明。  默认用预订单的商品列表。商品的总金额必须要等于订单总金额（total_amount)
        /// </summary>
        [JsonProperty("goods_detail")]
        public List<MallGoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复。如果不传，则以前置订单id对应的out_order_no作为该值。
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单付款总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]    如果同时传入了【可打折金额】，【不可打折金额】，【订单付款总金额】三者，则必须满足如下条件：【订单付款总金额】=【可打折金额】+【不可打折金额】
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。如果该值未传入，但传入了【订单付款总金额】和【可打折金额】，则该值默认为【订单付款总金额】-【可打折金额】
        /// </summary>
        [JsonProperty("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
