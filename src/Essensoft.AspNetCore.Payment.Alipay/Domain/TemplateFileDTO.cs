using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateFileDTO Data Structure.
    /// </summary>
    public class TemplateFileDTO : AlipayObject
    {
        /// <summary>
        /// 是否支持转赠，当设置为可转赠则可以在支付宝卡包中点击转赠按钮，将拥有的券转赠给其他用户。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("can_present")]
        public bool CanPresent { get; set; }

        /// <summary>
        /// 是否支持共享，如果支持共享则可以有多个用户拥有同一张卡券。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("can_share")]
        public bool CanShare { get; set; }

        /// <summary>
        /// 卡券模版版本信息，当前版本为4。不支持动态参数。
        /// </summary>
        [JsonPropertyName("format_version")]
        public string FormatVersion { get; set; }

        /// <summary>
        /// 卡券序列号，同一第三方提供的序列号需要唯一，同一用户重复添加的卡券，对应的serialNumber要求一致。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }
    }
}
