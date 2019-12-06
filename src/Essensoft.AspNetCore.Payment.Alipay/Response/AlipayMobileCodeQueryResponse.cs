using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobileCodeQueryResponse.
    /// </summary>
    public class AlipayMobileCodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务关联ID。比如订单号,userId，业务连接等
        /// </summary>
        [JsonPropertyName("biz_linked_id")]
        public string BizLinkedId { get; set; }

        /// <summary>
        /// 类似产品名称，根据该值决定码存储类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 码值的状态，  init:初始  normal:正常  pause:暂停  stop:停止
        /// </summary>
        [JsonPropertyName("code_status")]
        public string CodeStatus { get; set; }

        /// <summary>
        /// 业务自定义json字符串。
        /// </summary>
        [JsonPropertyName("context_str")]
        public string ContextStr { get; set; }

        /// <summary>
        /// 动态生成图片地址
        /// </summary>
        [JsonPropertyName("dynamic_img_url")]
        public string DynamicImgUrl { get; set; }

        /// <summary>
        /// 编码失效时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 如果是true，则扫一扫下发跳转地址直接取自BizLinkedId  否则，从路由信息里取跳转地址
        /// </summary>
        [JsonPropertyName("is_direct")]
        public string IsDirect { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务用到的码值
        /// </summary>
        [JsonPropertyName("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 原始码值
        /// </summary>
        [JsonPropertyName("qr_token")]
        public string QrToken { get; set; }

        /// <summary>
        /// 发码来源，业务自定
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 编码启动时间(yyyy-MM-dd hh:mm:ss)
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
