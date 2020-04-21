using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateColumnInfoDTO Data Structure.
    /// </summary>
    public class TemplateColumnInfoDTO : AlipayObject
    {
        /// <summary>
        /// 标准栏位：行为由支付宝统一定，同时已经分配标准Code  BALANCE：会员卡余额  POINT：积分  LEVEL：等级  TELEPHONE：联系方式  自定义栏位：行为由商户定义，自定义Code码（只要无重复）
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 若template_style_info.column_info_layout  的值为grid，此项为宫格项所属分组标题。可空。如果需要展示该项，还需支付宝内部进行特殊配置。
        /// </summary>
        [JsonPropertyName("group_title")]
        public string GroupTitle { get; set; }

        /// <summary>
        /// 若template_style_info.column_info_layout  的值为grid，此项为宫格项的展示icon。通过接口（alipay.offline.material.image.upload）上传图片。
        /// </summary>
        [JsonPropertyName("icon_id")]
        public string IconId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("more_info")]
        public MoreInfoDTO MoreInfo { get; set; }

        /// <summary>
        /// 1、openNative：打开二级页面，展现 more中descs  2、openWeb：打开URL  3、staticinfo：静态信息  注意：  不填则默认staticinfo；  标准code尽量使用staticinfo，例如TELEPHONE商家电话栏位就只支持staticinfo；
        /// </summary>
        [JsonPropertyName("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 若template_style_info.column_info_layout  的值为grid，此项为宫格项标签。可空。
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 栏目的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卡包详情页面，卡栏位右边展现的值    TELEPHONE栏位的商家联系电话号码由此value字段传入
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
