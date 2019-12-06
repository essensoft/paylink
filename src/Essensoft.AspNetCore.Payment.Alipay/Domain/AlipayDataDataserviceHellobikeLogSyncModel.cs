using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataDataserviceHellobikeLogSyncModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceHellobikeLogSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，表示用户在参与hellobike月卡打折活动中发生的业务操作（领券和购买月卡）；有两个枚举值：getvoucher:领券；pay:购买月卡；该参数由hellobike调用方所执行的业务操作确定取值。
        /// </summary>
        [JsonPropertyName("action_type")]
        public string ActionType { get; set; }

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
        /// 用户在hellobike购买月卡的实际金额，单位为分；action_type=pay的时候必传，其他场景不必传；该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("pay_price_cent")]
        public long PayPriceCent { get; set; }

        /// <summary>
        /// 用户购买hellobike月卡时使用的支付方式，目前和hellobike约定的几种支付方式为：alipay_account:支付宝支付，hellobike_account:hellobike余额，weixin_pay:微信支付；该参数取值为hellobike调用方自身的业务参数。
        /// </summary>
        [JsonPropertyName("pay_tool")]
        public string PayTool { get; set; }

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
