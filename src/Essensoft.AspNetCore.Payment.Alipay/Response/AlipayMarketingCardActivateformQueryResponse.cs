using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardActivateformQueryResponse.
    /// </summary>
    public class AlipayMarketingCardActivateformQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 表单提交信息各个字段的值JSON数组    通用表单字段名称如下示例：  OPEN_FORM_FIELD_MOBILE – 手机号  OPEN_FORM_FIELD_GENDER – 性别  OPEN_FORM_FIELD_NAME – 姓名  OPEN_FORM_FIELD_BIRTHDAY – 生日  OPEN_FORM_FIELD_IDCARD – 身份证  OPEN_FORM_FIELD_EMAIL – 邮箱  OPEN_FORM_FIELD_ADDRESS – 地址    详细字段名称列表见会员卡开卡表单模板配置接口：alipay.marketing.card.formtemplate.set    注：  1. 证件类型字段(OPEN_FORM_FIELD_CERT_TYPE)返回结果取值如下:      0 -- 身份证      1 -- 护照      2 -- 港澳居民通行证      3 -- 台湾居民通行证
        /// </summary>
        [JsonPropertyName("infos")]
        public string Infos { get; set; }
    }
}
