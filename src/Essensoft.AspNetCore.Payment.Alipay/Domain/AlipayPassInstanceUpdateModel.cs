using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassInstanceUpdateModel Data Structure.
    /// </summary>
    public class AlipayPassInstanceUpdateModel : AlipayObject
    {
        /// <summary>
        /// 代理商代替商户发放卡券后，再代替商户更新卡券时，此值为商户的pid/appid
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 商户指定卡券唯一值，卡券JSON模板中fileInfo->serialNumber字段对应的值
        /// </summary>
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 券状态，支持更新为USED、CLOSED两种状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模版动态参数信息：对应模板中$变量名$的动态参数，见模板创建接口返回值中的tpl_params字段
        /// </summary>
        [JsonPropertyName("tpl_params")]
        public string TplParams { get; set; }

        /// <summary>
        /// 核销码串值【当状态变更为USED时，建议传】。该值正常为模板中核销区域（Operation）对应的message值。
        /// </summary>
        [JsonPropertyName("verify_code")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// 核销方式，该值正常为模板中核销区域（Operation）对应的format值。verify_code和verify_type需同时传入。
        /// </summary>
        [JsonPropertyName("verify_type")]
        public string VerifyType { get; set; }
    }
}
