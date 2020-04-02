using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCommRuleShowInfo Data Structure.
    /// </summary>
    public class KbdishCommRuleShowInfo : AlipayObject
    {
        /// <summary>
        /// 规则扩展
        /// </summary>
        [JsonPropertyName("tag_ext_info")]
        public string TagExtInfo { get; set; }

        /// <summary>
        /// 键值如下： 组维度的规则： minLimit：组最小选择份数 maxLimit：组最大选择份数 required：是否必选 selectNum：可选选项数量，默认不限制 fold：是否折叠到进阶选择里 change: 是否可以置换 明细维度的规则： minLimit：明细最小选择份数 maxLimit：明细最大选择份数 addPrice：加价 addPriceStep：加价步长，默认为1 defaultNum：默认份数 default：是否默认 required：是否必选  规格组维度的规则： default:  是否默认 规则标签明细的规则: default:  是否默认 sort: 排序值 hidden:是否隐藏
        /// </summary>
        [JsonPropertyName("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 规则值 数字 或者是否 , 数字 或者true/false
        /// </summary>
        [JsonPropertyName("tag_value")]
        public string TagValue { get; set; }
    }
}
