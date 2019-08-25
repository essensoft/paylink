using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataAiservicePriceoptimizerDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 优惠算法类型，如： alipay_algo:支付宝算法 mer_algo:接入方自有算法 random:随机算法 fixed_amount:固定金额
        /// </summary>
        [JsonProperty("algo_type")]
        public string AlgoType { get; set; }

        /// <summary>
        /// 内部接口版本号
        /// </summary>
        [JsonProperty("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 原价，单位为分
        /// </summary>
        [JsonProperty("base_price")]
        public long BasePrice { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [JsonProperty("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写 交易类型为储值卡或周期卡类型时填写，如储值卡id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 扩展信息，json
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠领取方式 优惠领取方式，如： by_click:手动点击领取、 auto_recive:自动推送、 promotion:优惠活动(无券）
        /// </summary>
        [JsonProperty("get_coupon_method")]
        public string GetCouponMethod { get; set; }

        /// <summary>
        /// 代理商id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 操作类型，用于区分不同的数据回流类型  coupon:优惠领取  trade:优惠核销
        /// </summary>
        [JsonProperty("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写 单位为分。接入方内部优惠后的支付价格，不考虑其他渠道（如支付渠道）叠加的优惠
        /// </summary>
        [JsonProperty("payment_price")]
        public long PaymentPrice { get; set; }

        /// <summary>
        /// 优惠券核销数据回流时填写  支付渠道 alipay_account:支付宝支付 merchant_account:接入方账户余额 weixin_pay:微信支付
        /// </summary>
        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 如 online_car:网约车 card50:50元储值卡
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 优惠额度， 优惠类型为打折时，优惠额度取值是0-1之间的小数；为金额时单位为分。
        /// </summary>
        [JsonProperty("promo_price")]
        public long PromoPrice { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠领取入口
        /// </summary>
        [JsonProperty("promo_source")]
        public string PromoSource { get; set; }

        /// <summary>
        /// 优惠类型，如 present:赠送 discount:打折(或折扣券) reduction:立减(或现金券)
        /// </summary>
        [JsonProperty("promo_type")]
        public string PromoType { get; set; }

        /// <summary>
        /// 标识业务场景 single_pay:单次支付定价 stored_value_card:储值卡
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 接入方名称,不同业务方的区分
        /// </summary>
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 串联定价-领取-核销的唯一ID
        /// </summary>
        [JsonProperty("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 渠道 alipay_tinyapp:支付宝小程序 app:app客户端
        /// </summary>
        [JsonProperty("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 最小定价单元id 接入方有细分的定价单元时填写，如站点ID，没有时为空
        /// </summary>
        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 优惠券领取数据回流时填写 优惠有效期
        /// </summary>
        [JsonProperty("valid_time")]
        public string ValidTime { get; set; }
    }
}
