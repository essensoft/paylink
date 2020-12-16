using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateEInfoUnitDTO Data Structure.
    /// </summary>
    public class TemplateEInfoUnitDTO : AlipayObject
    {
        /// <summary>
        /// 显示icon的图片ID，通过接口（alipay.offline.material.image.upload）上传图片 图片说明：1M以内，格式bmp、png、jpeg、jpg，尺寸不小于100*100px。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 字段关键字标识，可作为聚合关键字，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 通栏左边显示文案，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 更多描述，当字段类型为：url（网站连接地址）时必填，用于存放跳转链接。
        /// </summary>
        [JsonPropertyName("more")]
        public TemplateEInfoMoreDTO More { get; set; }

        /// <summary>
        /// 字段类型，可选类型有：tel（电话）、url（网站连接地址）、map（地图）、text（文本，默认类型)。根据不同的类型，将在该字段前添加相应的icon，并会根据实际情况相应支持电话拨出、启动浏览器跳转连接地址、启动手机应用客户端、地图等功能。支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 通栏右边显示具体值，支持以 $动态参数$ 形式的自定义动态参数传值。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
