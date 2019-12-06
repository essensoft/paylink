using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationGroupApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationGroupApplyModel : AlipayObject
    {
        /// <summary>
        /// 收件人
        /// </summary>
        [JsonPropertyName("addressee")]
        public InsAddressee Addressee { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 投保申请信息列表
        /// </summary>
        [JsonPropertyName("applications")]
        public List<InsApplication> Applications { get; set; }

        /// <summary>
        /// 保费支付账单流水的标题
        /// </summary>
        [JsonPropertyName("bill_title")]
        public string BillTitle { get; set; }

        /// <summary>
        /// 权益，可选不唯一，优惠使用，优惠决策时产生。
        /// </summary>
        [JsonPropertyName("coupons")]
        public List<InsCoupon> Coupons { get; set; }

        /// <summary>
        /// 优惠单号，可选不唯一，优惠使用，优惠决策时产生。
        /// </summary>
        [JsonPropertyName("discount_id")]
        public string DiscountId { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号,必须保证唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品编码;由蚂蚁保险平台分配,商户通过该产品编码投保特定的保险产品
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 报价单号，可选不唯一，用于指定投保订单对应的报价单，报价时产生。
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}
