using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherUseModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherUseModel : AlipayObject
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 外部优惠券的核销时间。    格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 商品明细信息。    限制：  当前交易中存在商品信息，则建议传入商品明细信息。
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetailDTO> GoodsDetail { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单优惠前的总金额    限制：  该笔订单的资金总额，取值范围[0.01,100000000]，精确到小数点后2位。
        /// </summary>
        [JsonPropertyName("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易渠道。    枚举值：  ZHIFUBAO_TRADE_CHANNEL：  支付宝交易渠道    WX_TRADE_CHANNEL：  微信交易渠道    OTHER_TRADE_CHANNEL：  其他交易渠道
        /// </summary>
        [JsonPropertyName("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 待核销的券码。
        /// </summary>
        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
