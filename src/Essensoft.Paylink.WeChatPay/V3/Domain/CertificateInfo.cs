using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 登记证书
    /// </summary>
    public class CertificateInfo : WeChatPayObject
    {
        /// <summary>
        /// 登记证书照片
        /// </summary>
        /// <remarks>
        /// 1、请填写通过《图片上传API》预先生成的MediaID，上传1张图片即可；
        /// 2、请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水 印（如微信支付认证） 。
        /// <para>示例值: 0P3ng6_XXqK5dE5YdOmFJBZR9FwczhJehHhAZN6BKXQPcs-VvdSo</para>
        /// </remarks>
        [JsonPropertyName("cert_copy")]
        public string CertCopy { get; set; }

        /// <summary>
        /// 登记证书类型
        /// </summary>
        /// <remarks>
        /// 1、主体为“政府机关/事业单位/社会组织”时，请上传登记证书类型。
        /// 2、主体为“个体工商户/企业”时，不填。
        /// 当主体为事业单位时，选择此枚举值：
        /// CERTIFICATE_TYPE_2388：事业单位法人证书
        /// 当主体为政府机关，选择此枚举值：
        /// CERTIFICATE_TYPE_2389：统一社会信用代码证书
        /// 当主体为社会组织，选择以下枚举值之一：
        /// CERTIFICATE_TYPE_2389：统一社会信用代码证书
        /// CERTIFICATE_TYPE_2394：社会团体法人登记证书
        /// CERTIFICATE_TYPE_2395：民办非企业单位登记证书
        /// CERTIFICATE_TYPE_2396：基金会法人登记证书
        /// CERTIFICATE_TYPE_2397：慈善组织公开募捐资格证书( 已废弃)
        /// CERTIFICATE_TYPE_2398：农民专业合作社法人营业执照(已废弃)
        /// CERTIFICATE_TYPE_2520：执业许可证/执业证
        /// CERTIFICATE_TYPE_2521：基层群众性自治组织特别法人统一社会信用代码证
        /// CERTIFICATE_TYPE_2522：农村集体经济组织登记证
        /// CERTIFICATE_TYPE_2399：宗教活动场所登记证
        /// CERTIFICATE_TYPE_2400：政府部门下发的其他有效证明文件
        /// <para>示例值：CERTIFICATE_TYPE_2388</para>
        /// </remarks>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证书号
        /// </summary>
        /// <remarks>
        /// 请填写登记证书上的证书编号。
        /// <para>示例值：111111111111</para>
        /// </remarks>
        [JsonPropertyName("cert_number")]
        public string CertNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <remarks>
        /// 请填写登记证书上的商户名称。
        /// <para>示例值：xx公益团体</para>
        /// </remarks>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        /// <remarks>
        /// 请填写登记证书的注册地址。
        /// <para>示例值：广东省深圳市南山区xx路xx号</para>
        /// </remarks>
        [JsonPropertyName("company_address")]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        /// <remarks>
        /// 1、只能由中文字符、英文字符、可见符号组成。
        /// 2、请填写登记证书上的法定代表人姓名。
        /// <para>示例值：李四</para>
        /// </remarks>
        [JsonPropertyName("legal_person")]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 有效期限开始日期
        /// </summary>
        /// <remarks>
        /// 1、必填， 请参考示例值填写。
        /// 2、开始日期，开始日期需大于当前日期
        /// <para>示例值：2019-08-01</para>
        /// </remarks>
        [JsonPropertyName("period_begin")]
        public string PeriodBegin { get; set; }

        /// <summary>
        /// 有效期限结束日期
        /// </summary>
        /// <remarks>
        /// 1、必填，请参考示例值填写。
        /// 2、若证件有效期为长期，请填写：长期。
        /// 3、结束日期大于开始日期。
        /// 4、有效期必须大于60天。
        /// <para>示例值：2029-08-01，长期</para>
        /// </remarks>
        [JsonPropertyName("period_end")]
        public string PeriodEnd { get; set; }
    }
}
