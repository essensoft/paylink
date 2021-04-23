using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceBikepriceDataSyncModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceBikepriceDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 渠道来源，跳转到渠道(流量位)的上一级页面(由调用方定义渠道枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("ad_source")]
        public string AdSource { get; set; }

        /// <summary>
        /// 骑行卡原价，单位为分
        /// </summary>
        [JsonPropertyName("base_price")]
        public long BasePrice { get; set; }

        /// <summary>
        /// 领取时间，格式为yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 优惠卡类型，枚举值为 mcard,qcard,hycard,ycard,tcard
        /// </summary>
        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡型代码版本,0为旧版卡型代码(默认),1为新版卡型代码
        /// </summary>
        [JsonPropertyName("card_type_version")]
        public long CardTypeVersion { get; set; }

        /// <summary>
        /// 城市码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 外部业务扩展参数,包括外部特征及外部扩展参数
        /// </summary>
        [JsonPropertyName("make_price_ext_params")]
        public MakePriceExtParams MakePriceExtParams { get; set; }

        /// <summary>
        /// 操作类型，用于区分不同的数据回流类型 coupon:优惠领取 trade:优惠核销
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 外部userId(哈啰)
        /// </summary>
        [JsonPropertyName("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 业务端口，安卓、iOS、支付宝小程序、微信、H5、高德
        /// </summary>
        [JsonPropertyName("plat_form")]
        public string PlatForm { get; set; }

        /// <summary>
        /// 排序优先级,数字越小,优先级越高,没有经过排序的卡类型默认返回-1(预留字段)
        /// </summary>
        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 领取渠道。 alipay_tinyapp:支付宝小程序 alipay_promo:支付宝大促活动 如有其它枚举值或者以后新增枚举值，请给出枚举值list和对应中文解释。
        /// </summary>
        [JsonPropertyName("promo_channel")]
        public string PromoChannel { get; set; }

        /// <summary>
        /// 出价(即卡建议售价)，单位为分
        /// </summary>
        [JsonPropertyName("promotion_price")]
        public long PromotionPrice { get; set; }

        /// <summary>
        /// 优惠算法类型 alipay_algo:支付宝算法 hello_algo:哈罗算法 no_coupon_used:未使用优惠券
        /// </summary>
        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 标识业务场景 bike_coupon_info:单车 ebike_coupon_info:电单车
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景的来源渠道，本场景传入alipay_hellobike
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 券领取入口。 该参数取值为调用方自身的业务参数。(由调用方定义枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 系统平台代码,有支付宝,ios,安卓等
        /// </summary>
        [JsonPropertyName("system_code")]
        public string SystemCode { get; set; }

        /// <summary>
        /// 串联定价-领取-核销的唯一ID
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 新老用户标签 该参数取值为调用方自身的业务参数(由调用方定义枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("user_attribute")]
        public string UserAttribute { get; set; }

        /// <summary>
        /// 目标用户ID传入用户的支付宝user_id（如无支付宝user_id本字段可空）
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 优惠券有效期，格式为yyyy-mm-dd hh:mm:ss
        /// </summary>
        [JsonPropertyName("valid_time")]
        public string ValidTime { get; set; }
    }
}
