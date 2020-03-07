using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberAuthApplyResponse.
    /// </summary>
    public class KoubeiMarketingCampaignMemberAuthApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 表单提交信息各个字段的值JSON    通用表单字段名称如下示例：   OPEN_FORM_FIELD_MOBILE – 手机号   OPEN_FORM_FIELD_GENDER – 性别   OPEN_FORM_FIELD_NAME – 姓名   OPEN_FORM_FIELD_BIRTHDAY_WITH_YEAR – 生日
        /// </summary>
        [JsonPropertyName("infos")]
        public string Infos { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
