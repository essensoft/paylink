using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Notify
{
    /// <summary>
    /// 微信代扣 - 车主平台 - 车牌状态变更通知 (普通商户 / 服务商)
    /// </summary>
    [XmlRoot("xml")]
    public class WeChatPayVehiclePartnerPayNotificationNotify : WeChatPayNotify
    {
        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        [XmlElement("sub_mch_id")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 应用号
        /// </summary>
        [XmlElement("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用号
        /// </summary>
        [XmlElement("sub_appid")]
        public string SubAppId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_number")]
        public string PlateNumber { get; set; }

        /// <summary>
        /// 车牌变更事件类型
        /// </summary>
        [XmlElement("vehicle_event_type")]
        public string VehicleEventType { get; set; }

        /// <summary>
        /// 车牌变更事件信息
        /// </summary>
        [XmlElement("vehicle_event_des")]
        public string VehicleEventDes { get; set; }

        /// <summary>
        /// 用户标识	
        /// </summary>
        [XmlElement("openid")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户子标识	
        /// </summary>
        [XmlElement("sub_openid")]
        public string SubOpenId { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [XmlElement("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [XmlElement("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 车牌变更事件发生时间
        /// </summary>
        [XmlElement("vehicle_event_createtime")]
        public string VehicleEventCreateTime { get; set; }

        /// <summary>
        /// 车牌信息
        /// </summary>
        [XmlElement("plate_number_info")]
        public string PlateNumberInfo { get; set; }
    }
}
