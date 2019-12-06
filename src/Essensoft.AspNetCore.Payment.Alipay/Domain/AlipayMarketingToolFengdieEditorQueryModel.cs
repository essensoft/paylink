using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieEditorQueryModel : AlipayObject
    {
        /// <summary>
        /// 凤蝶H5应用唯一id，通过alipay.marketing.tool.fengdie.activity.create接口时自动生成
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 在凤蝶编辑器中点击“发布”按钮后，如果发布成功则跳转到该地址
        /// </summary>
        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
