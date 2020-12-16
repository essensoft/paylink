using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplatePlatformDTO Data Structure.
    /// </summary>
    public class TemplatePlatformDTO : AlipayObject
    {
        /// <summary>
        /// 卡券所属业务线，如飞猪在其内部营销平台里，通过营销活动为新用户发放优惠券，那此处填写飞猪业务线：fliggy。支持自定义动态参数传值，但动态参数需定义为：$_r_biz_from_bu$。
        /// </summary>
        [JsonPropertyName("biz_from_bu")]
        public string BizFromBu { get; set; }

        /// <summary>
        /// 卡券所属业务平台，如飞猪在其内部营销平台里，通过营销活动为新用户发放优惠券，那此处填写营销平台名称：marketing。支持自定义动态参数传值，但动态参数需定义为：$_r_biz_from_platform$。
        /// </summary>
        [JsonPropertyName("biz_from_platform")]
        public string BizFromPlatform { get; set; }

        /// <summary>
        /// 卡券所属业务场景，如飞猪在其内部营销平台里，通过营销活动为新用户发放优惠券，那此处填写营销活动编码：newUserPromo。支持自定义动态参数传值，但动态参数需定义为：$_r_biz_from_scene$。
        /// </summary>
        [JsonPropertyName("biz_from_scene")]
        public string BizFromScene { get; set; }

        /// <summary>
        /// 卡券所属商户在支付宝的商户号(pid)，如代理商代替商户设置卡券时，此值为被代理的商户的商户号(pid)。支持以 $动态参数$ 形式的自定义动态参数传值，但动态参数需定义为$channelID$。
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 渠道商服务地址，用于将支付宝相关的信息同步给第三方，需要带上http、https、alipays等协议头。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("web_service_url")]
        public string WebServiceUrl { get; set; }
    }
}
