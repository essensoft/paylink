using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InputFieldModel Data Structure.
    /// </summary>
    public class InputFieldModel : AlipayObject
    {
        /// <summary>
        /// 默认提示值，例如歌华宽带的金额为100的倍数
        /// </summary>
        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 域英文名称 例如：billkey
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 输入框下方文字提示，例如： 户号为10位数字
        /// </summary>
        [JsonPropertyName("field_tips")]
        public string FieldTips { get; set; }

        /// <summary>
        /// 页面显示提示 例如：手机号码
        /// </summary>
        [JsonPropertyName("field_title")]
        public string FieldTitle { get; set; }

        /// <summary>
        /// 控件类型 输入框类型 例如：inputText (文本输入框)
        /// </summary>
        [JsonPropertyName("field_type")]
        public string FieldType { get; set; }

        /// <summary>
        /// 控件展示顺序 例如：优选级 1
        /// </summary>
        [JsonPropertyName("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// 输入域的校验规则模型
        /// </summary>
        [JsonPropertyName("regexp_rule_list")]
        public List<ValidationRule> RegexpRuleList { get; set; }
    }
}
