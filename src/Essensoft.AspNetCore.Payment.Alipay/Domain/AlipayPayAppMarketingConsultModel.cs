using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayAppMarketingConsultModel Data Structure.
    /// </summary>
    public class AlipayPayAppMarketingConsultModel : AlipayObject
    {
        /// <summary>
        /// 业务场景，用于区分商户具体的咨场景，示例：ORDER_PAGE：下单页营销咨询；其他新场景接入时需与支付宝协商约定
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 使用morse匿名技术对原始手机号MD5值进行盲化后的结果(可通过morse工具包生成)； 若接口调用采用morse匿名方式，此字段必须与混淆后的手机号列表(confused_mobile_list)字段一起传入，二者缺一不可
        /// </summary>
        [JsonPropertyName("blind_mobile")]
        public string BlindMobile { get; set; }

        /// <summary>
        /// 混淆后的手机号MD5值列表； 若接口调用采用morse匿名方式，此字段必须与盲化的原始手机号MD5值(blind_mobile)字段一起传入，二者缺一不可；
        /// </summary>
        [JsonPropertyName("confused_mobile_list")]
        public List<string> ConfusedMobileList { get; set; }

        /// <summary>
        /// 设备号密文，使用SHA256加密；设备号类型由device_type字段指定；（手机号、设备号或morse匿名查询，三种匹配方式至少有一种参数不能为空）
        /// </summary>
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备号类型，与设备号device_id字段组合使用，默认为IMEI
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 手机号md5值密文；（手机号、设备号或morse匿名查询，三种匹配方式至少有一种参数不能为空）
        /// </summary>
        [JsonPropertyName("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式，其它说明详见商品明细说明；取值可参考alipay.trade.app.pay(app支付接口2.0)
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 已废弃不支持
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 是否需要返回标签信息；默认为false不返回
        /// </summary>
        [JsonPropertyName("need_return_tag")]
        public bool NeedReturnTag { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠参数 注：仅与支付宝协商后可用；取值可参考alipay.trade.app.pay(app支付接口2.0)
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 收款支付宝账号对应的支付宝唯一用户号。 以2088开头的纯16位数字
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
