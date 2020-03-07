using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerDataSyncModel Data Structure.
    /// </summary>
    public class AlipayDataAiservicePriceoptimizerDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 优惠算法类型，如： alipay_algo:支付宝算法 mer_algo:接入方自有算法 random:随机算法 fixed_amount:固定金额 (可不传)
        /// </summary>
        [JsonPropertyName("algo_type")]
        public string AlgoType { get; set; }

        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 原价，单位为分(可不传)
        /// </summary>
        [JsonPropertyName("base_price")]
        public long BasePrice { get; set; }

        /// <summary>
        /// 事件时间(可不传)
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写 交易类型为储值卡或周期卡类型时填写，如储值卡id (可不传)
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 市,可不传
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扩展信息，json字符串格式。 如：对于哈啰数据回流场景，这个字段内容为 原opdata字段内容，注意在json字符串中新增priority字段表示该卡是否经过排序, 数字越大，优先级越高，-1表示没有经过排序
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠领取方式 优惠领取方式，如： by_click:手动点击领取、 auto_recive:自动推送、 promotion:优惠活动(无券)(可不传)
        /// </summary>
        [JsonPropertyName("get_coupon_method")]
        public string GetCouponMethod { get; set; }

        /// <summary>
        /// 代理商id(可不传)
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 操作类型，用于区分不同的数据回流类型  coupon:优惠领取  trade:优惠核销 (可不传)
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写 单位为分。接入方内部优惠后的支付价格，不考虑其他渠道（如支付渠道）叠加的优惠 (可不传)
        /// </summary>
        [JsonPropertyName("payment_price")]
        public long PaymentPrice { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写 支付渠道 alipay_account:支付宝支付 merchant_account:接入方账户余额 weixin_pay:微信支付 (可不传)
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 如 online_car:网约车 card50:50元储值卡(可不传)
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 优惠额度， 优惠类型为打折时，优惠额度取值是0-1之间的小数；为金额时单位为分。(可不传)
        /// </summary>
        [JsonPropertyName("promo_price")]
        public long PromoPrice { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠领取入口(可不传)
        /// </summary>
        [JsonPropertyName("promo_source")]
        public string PromoSource { get; set; }

        /// <summary>
        /// 优惠类型，如 present:赠送 discount:打折(或折扣券) reduction:立减(或现金券)(可不传)
        /// </summary>
        [JsonPropertyName("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 标识业务场景 bike_coupon_info:单车 ebike_coupon_info:电单车
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景的来源渠道，本场景传入hellobike
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 串联定价-领取-核销的唯一ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 渠道 alipay_tinyapp:支付宝小程序 app:app客户端(可不传)
        /// </summary>
        [JsonPropertyName("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 最小定价单元id 接入方有细分的定价单元时填写，如站点ID，没有时为空(可不传)
        /// </summary>
        [JsonPropertyName("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 目标用户ID传入用户的支付宝user_id（如无支付宝user_id本字段可空）
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠有效期(可不传)
        /// </summary>
        [JsonPropertyName("valid_time")]
        public string ValidTime { get; set; }
    }
}
