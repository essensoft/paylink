using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassInstanceUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassInstanceUpdateModel : AlipayObject
    {
        /// <summary>
        /// 代理商代替商户发放卡券后，再代替商户更新卡券时，此值为商户的pid/appid
        /// </summary>
        [JsonProperty("channel_id")]
        [XmlElement("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 商户指定卡券唯一值，卡券JSON模板中fileInfo->serialNumber字段对应的值
        /// </summary>
        [JsonProperty("serial_number")]
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 券状态，支持更新为USED、CLOSED两种状态
        /// </summary>
        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模版动态参数信息：对应模板中$变量名$的动态参数，见模板创建接口返回值中的tpl_params字段
        /// </summary>
        [JsonProperty("tpl_params")]
        [XmlElement("tpl_params")]
        public string TplParams { get; set; }

        /// <summary>
        /// 核销码串值【当状态变更为USED时，建议传】
        /// </summary>
        [JsonProperty("verify_code")]
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// 核销方式，目前支持：wave（声波方式）、qrcode（二维码方式）、barcode（条码方式）、input（文本方式，即手工输入方式）。verify_code和verify_type需同时传入
        /// </summary>
        [JsonProperty("verify_type")]
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
