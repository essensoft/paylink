using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// JFExportInputFieldModel Data Structure.
    /// </summary>
    public class JFExportInputFieldModel : AlipayObject
    {
        /// <summary>
        /// STANDARD_DATA(标准数据)，对应的是查询机构账单请求中的参数，目前机构账单查询请求中包含billkey、ownerName和billDate这三个参数；EXTEND_DATA(拓展数据)，则以field_name为key，把用户输入的值放到拓展字段中
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 输入框的默认值，可以删除后重新输入
        /// </summary>
        [JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 域英文名称 例如：billkey、ownerName和billDate，需要结合data_type字段来使用。
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 输入框下方文字提示，例如： 户号为10位数字
        /// </summary>
        [JsonPropertyName("field_tips")]
        public string FieldTips { get; set; }

        /// <summary>
        /// 页面显示提示 例如：户号
        /// </summary>
        [JsonPropertyName("field_title")]
        public string FieldTitle { get; set; }

        /// <summary>
        /// 控件类型 输入框类型 例如：inputText (文本输入框)
        /// </summary>
        [JsonPropertyName("field_type")]
        public string FieldType { get; set; }

        /// <summary>
        /// 输入域的最近修改时间，可以用于判断输入域数据最近是否有更新。
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 获取场景:load，加载展示，渲染初始页面时的场景；query，查询展示, 查询成功后确认页面的场景。
        /// </summary>
        [JsonPropertyName("mode_type")]
        public string ModeType { get; set; }

        /// <summary>
        /// 控件展示顺序 例如：1，展示到最前面
        /// </summary>
        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 输入域的正则校验规则列表
        /// </summary>
        [JsonPropertyName("regexp_rules")]
        public List<ValidationRule> RegexpRules { get; set; }
    }
}
