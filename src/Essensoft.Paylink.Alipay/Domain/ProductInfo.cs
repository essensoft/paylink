using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductInfo Data Structure.
    /// </summary>
    public class ProductInfo : AlipayObject
    {
        /// <summary>
        /// 场馆的产品购买限制规则信息
        /// </summary>
        [JsonPropertyName("can_buy_rule")]
        public ProductBuyLimitRule CanBuyRule { get; set; }

        /// <summary>
        /// 是否支持退款，可退款为true，不可退款为false，不传默认true可退款
        /// </summary>
        [JsonPropertyName("can_refund")]
        public bool CanRefund { get; set; }

        /// <summary>
        /// 产品开始使用前多长时间(分钟)可退款，不传默认开始前30分钟都可退款；产品不可退款(can_refund=false)时不需要传值。
        /// </summary>
        [JsonPropertyName("can_refund_minute")]
        public long CanRefundMinute { get; set; }

        /// <summary>
        /// 产品分类列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<ProductCategoryInfo> CategoryList { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 产品使用结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 须知
        /// </summary>
        [JsonPropertyName("notice")]
        public string Notice { get; set; }

        /// <summary>
        /// 产品原价(单位：元),保留2位小数
        /// </summary>
        [JsonPropertyName("origin_price")]
        public string OriginPrice { get; set; }

        /// <summary>
        /// 服务商的产品ID
        /// </summary>
        [JsonPropertyName("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 产品海报图片地址
        /// </summary>
        [JsonPropertyName("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 退改规则的自定义文本描述
        /// </summary>
        [JsonPropertyName("refund_desc")]
        public string RefundDesc { get; set; }

        /// <summary>
        /// 产品售卖价(单位：元),保留2位小数
        /// </summary>
        [JsonPropertyName("sale_price")]
        public string SalePrice { get; set; }

        /// <summary>
        /// 产品可使用开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 产品库存,无限库存就99999
        /// </summary>
        [JsonPropertyName("stock_count")]
        public long StockCount { get; set; }

        /// <summary>
        /// 凭证类型： 1-动态二维码 2-静态二维码 3-购买信息(订单号-姓名-手机号)
        /// </summary>
        [JsonPropertyName("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 凭证核销方式： 核销方式： 1-无需核销(已支付- >订单完成) 2-自动核销(已支付- >时间超过产品使用时间- >订单完成) 3-服务商核销确认(已支付- >对接核销通知接口- >订单完成)
        /// </summary>
        [JsonPropertyName("voucher_verify_type")]
        public string VoucherVerifyType { get; set; }
    }
}
