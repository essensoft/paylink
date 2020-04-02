using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDetail Data Structure.
    /// </summary>
    public class VoucherDetail : AlipayObject
    {
        /// <summary>
        /// 优惠券面额，它应该会等于商家出资加上其他出资方出资
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 优惠券备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商家出资（特指发起交易的商家出资金额）
        /// </summary>
        [JsonPropertyName("merchant_contribute")]
        public string MerchantContribute { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资
        /// </summary>
        [JsonPropertyName("other_contribute")]
        public string OtherContribute { get; set; }

        /// <summary>
        /// 优惠券的其他出资方明细
        /// </summary>
        [JsonPropertyName("other_contribute_detail")]
        public List<ContributeDetail> OtherContributeDetail { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时平台优惠的金额
        /// </summary>
        [JsonPropertyName("purchase_ant_contribute")]
        public string PurchaseAntContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时用户实际付款的金额
        /// </summary>
        [JsonPropertyName("purchase_buyer_contribute")]
        public string PurchaseBuyerContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时商户优惠的金额
        /// </summary>
        [JsonPropertyName("purchase_merchant_contribute")]
        public string PurchaseMerchantContribute { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券类型，如： ALIPAY_FIX_VOUCHER - 全场代金券 ALIPAY_DISCOUNT_VOUCHER - 折扣券 ALIPAY_ITEM_VOUCHER - 单品优惠券 ALIPAY_CASH_VOUCHER - 现金抵价券 ALIPAY_BIZ_VOUCHER - 商家全场券 注：不排除将来新增其他类型的可能，商家接入时注意兼容性避免硬编码
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
