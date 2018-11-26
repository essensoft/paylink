using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneCouponSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneCouponSendModel : AlipayObject
    {
        /// <summary>
        /// 渠道账号对应的uid;如果证件类型字段没填则必填
        /// </summary>
        [JsonProperty("channel_user_id")]
        [XmlElement("channel_user_id")]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// 渠道账号来源;1:支付宝账号 2:淘宝账号;如果证件类型字段没填则必填
        /// </summary>
        [JsonProperty("channel_user_source")]
        [XmlElement("channel_user_source")]
        public string ChannelUserSource { get; set; }

        /// <summary>
        /// 活动维度id;  商户PID值
        /// </summary>
        [JsonProperty("dimension_id")]
        [XmlElement("dimension_id")]
        public string DimensionId { get; set; }

        /// <summary>
        /// 活动维度;  GOODS:淘宝商品,ANT_PID:蚂蚁商户PID
        /// </summary>
        [JsonProperty("dimension_type")]
        [XmlElement("dimension_type")]
        public string DimensionType { get; set; }

        /// <summary>
        /// 市场类型;  TAOBAO:淘宝平台,ANT: 蚂蚁平台
        /// </summary>
        [JsonProperty("market_type")]
        [XmlElement("market_type")]
        public string MarketType { get; set; }

        /// <summary>
        /// 商户生成的外部业务号,必须保证唯一，幂等控制
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务场景;  propertyPaySuccess:蚂蚁物业支付成功页面
        /// </summary>
        [JsonProperty("service_scenario")]
        [XmlElement("service_scenario")]
        public string ServiceScenario { get; set; }
    }
}
