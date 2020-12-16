using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceSmartpriceGetModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceSmartpriceGetModel : AlipayObject
    {
        /// <summary>
        /// 渠道来源，跳转到渠道(流量位)的上一级页面
        /// </summary>
        [JsonPropertyName("ad_source")]
        public string AdSource { get; set; }

        /// <summary>
        /// 兼容V1.0。月卡售卖原价，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("base_price_cent")]
        public long BasePriceCent { get; set; }

        /// <summary>
        /// 卡型代码版本,0为旧版卡型代码(默认),1为新版卡型代码
        /// </summary>
        [JsonPropertyName("card_type_version")]
        public long CardTypeVersion { get; set; }

        /// <summary>
        /// 用户购买hellobike月卡的渠道，目前有两种：alipay_tinyapp:小程序, hellobike_app:hellobike客户端，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码，国标码，hellobike定位到的用户当前所在城市，该参数由hellobike调用方定位用户当前所在城市得到。
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 价格限定条件，用于不同优惠卡之间的价格不等式约束
        /// </summary>
        [JsonPropertyName("conditions")]
        public List<HelloBikePriceCondition> Conditions { get; set; }

        /// <summary>
        /// 请求约束条件，用于约束优惠卡的出价区间等信息
        /// </summary>
        [JsonPropertyName("constraints")]
        public List<HelloBikePriceConstraint> Constraints { get; set; }

        /// <summary>
        /// 兼容V1.0。用户参与月卡打折活动时，默认的折扣价格，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("default_promo_price_cent")]
        public long DefaultPromoPriceCent { get; set; }

        /// <summary>
        /// 渠道(流量位)，如购卡页和待支付页。该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// 兼容V1.0。月卡售价区间范围的上限，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("high_price_cent")]
        public long HighPriceCent { get; set; }

        /// <summary>
        /// 兼容V1.0。月卡售价区间范围的下限，单位为分，该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("lower_price_cent")]
        public long LowerPriceCent { get; set; }

        /// <summary>
        /// 业务端口，安卓、iOS、支付宝小程序、微信、H5、高德
        /// </summary>
        [JsonPropertyName("plat_form")]
        public string PlatForm { get; set; }

        /// <summary>
        /// 这个请求是否经过排序的标记位,默认为false
        /// </summary>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 场景码，目前用于区分「单车」和「电单车」两种场景，其中，单车对应 bike， 电单车对应 ebike。不传该字段，默认为单车。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 系统平台代码,有支付宝小程序,ios,安卓等
        /// </summary>
        [JsonPropertyName("system_code")]
        public string SystemCode { get; set; }

        /// <summary>
        /// 用户参与一次月卡打折活动的业务标识，需要唯一。通过该业务标识串联用户在一次月卡打折活动中的涉及的关键业务流程（调用alipay.data.aiservice.smartprice.get接口获取用户购买月卡的活动价格、领取折扣券、购买月卡3个业务流程），该参数由hellobike业务端生成该id并在上述3个业务流程推进过程中存储记录该id。
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，作为用户标识，该参数可通过alipay.user.info.share接口获取。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
