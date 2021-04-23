using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceBikepriceGetModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceBikepriceGetModel : AlipayObject
    {
        /// <summary>
        /// 渠道来源，跳转到渠道(流量位)的上一级页面(由调用方定义渠道枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("ad_source")]
        public string AdSource { get; set; }

        /// <summary>
        /// 卡型代码版本,0为旧版卡型代码(默认),1为新版卡型代码
        /// </summary>
        [JsonPropertyName("card_type_version")]
        public long CardTypeVersion { get; set; }

        /// <summary>
        /// 用户购买hellobike月卡的渠道，目前有两种：alipay_tinyapp:小程序, hellobike_app:hellobike客户端，该参数取值为hellobike调用方自身的业务参数。端内售卡场景取alipay_app
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 请求约束条件，用于约束优惠卡的出价区间等信息
        /// </summary>
        [JsonPropertyName("constraints")]
        public List<CardPriceRequestItem> Constraints { get; set; }

        /// <summary>
        /// 渠道(流量位)，如购卡页(0)和待支付页(1)。该参数取值为调用方自身的业务参数。(由调用方定义流量位枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// 外部业务扩展参数,包括外部特征及外部扩展参数
        /// </summary>
        [JsonPropertyName("make_price_ext_params")]
        public MakePriceExtParams MakePriceExtParams { get; set; }

        /// <summary>
        /// 业务端口，安卓、iOS、支付宝小程序、微信、H5、高德
        /// </summary>
        [JsonPropertyName("plat_form")]
        public string PlatForm { get; set; }

        /// <summary>
        /// 是否要对周期卡展示顺序进行排序，默认false
        /// </summary>
        [JsonPropertyName("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// 场景码，目前用于区分「单车」和「电单车」两种场景，其中，单车对应 bike， 电单车对应 ebike。不传该字段，默认为单车。
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 服务场景标示,本场景传入alipay_hellobike
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 系统平台代码,有支付宝,ios,安卓等
        /// </summary>
        [JsonPropertyName("system_code")]
        public string SystemCode { get; set; }

        /// <summary>
        /// 业务流水id(接口调用生成传入，需唯一，与后续数据回流中的业务id保持统一)
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 新老用户标签 该参数取值为调用方自身的业务参数(由调用方定义枚举，给出对应英文代码或中文解释)
        /// </summary>
        [JsonPropertyName("user_attribute")]
        public string UserAttribute { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
