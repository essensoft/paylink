using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileCodeCreateResponse.
    /// </summary>
    public class AlipayMobileCodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务关联的id，如订单号,userId
        /// </summary>
        [JsonProperty("biz_linked_id")]
        [XmlElement("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 业务类型，类型产品名称
        /// </summary>
        [JsonProperty("biz_type")]
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 码值状态，  init:初始  normal:正常  pause:暂停  stop:停止
        /// </summary>
        [JsonProperty("code_status")]
        [XmlElement("code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 发码接口传入的扩展参数，业务自定义,码平台不用理解。
        /// </summary>
        [JsonProperty("context_str")]
        [XmlElement("context_str")]
        public string ContextStr { get; set; }

        /// <summary>
        /// 动态生成图片地址
        /// </summary>
        [JsonProperty("dynamic_img_url")]
        [XmlElement("dynamic_img_url")]
        public string DynamicImgUrl { get; set; }

        /// <summary>
        /// 编码失效时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        [JsonProperty("expire_date")]
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 如果是true，则扫一扫下发跳转地址直接取自BizLinkedId  否则，从路由信息里取跳转地址
        /// </summary>
        [JsonProperty("is_direct")]
        [XmlElement("is_direct")]
        public string IsDirect { get; set; }

        /// <summary>
        /// 备注信息字段
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务用到的码值
        /// </summary>
        [JsonProperty("qr_code")]
        [XmlElement("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 原始码值
        /// </summary>
        [JsonProperty("qr_token")]
        [XmlElement("qr_token")]
        public string QrToken { get; set; }

        /// <summary>
        /// 发码来源，业务自定义
        /// </summary>
        [JsonProperty("source_id")]
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 编码启动时间（yyy-MM-dd hh:mm:ss），为空表示立即启用
        /// </summary>
        [JsonProperty("start_date")]
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 发码请求中带的支付宝用户id
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
