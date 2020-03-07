using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMallScanpurchaseTraderesultQueryResponse.
    /// </summary>
    public class KoubeiMallScanpurchaseTraderesultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// banner的位置广告图片。json格式数据
        /// </summary>
        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        /// <summary>
        /// 买家支付宝用户ID
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 消费送数据信息
        /// </summary>
        [JsonPropertyName("consume_voucher")]
        public MallConsumeVoucher ConsumeVoucher { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("goods_details")]
        public List<MallGoodsDetail> GoodsDetails { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商圈场景订单
        /// </summary>
        [JsonPropertyName("scene_order")]
        public SceneOrder SceneOrder { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID
        /// </summary>
        [JsonPropertyName("seller_user_id")]
        public string SellerUserId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 核销码信息
        /// </summary>
        [JsonPropertyName("user_verify")]
        public MallUserVerify UserVerify { get; set; }
    }
}
