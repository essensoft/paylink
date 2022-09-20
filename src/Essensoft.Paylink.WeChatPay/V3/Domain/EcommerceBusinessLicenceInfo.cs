using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 营业执照/登记证书信息
    /// </summary>
    public class EcommerceBusinessLicenceInfo : WeChatPayObject
    {
        /// <summary>
        /// 证书类型
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
        /// CERTIFICATE_TYPE_2399：宗教活动场所登记证
        /// CERTIFICATE_TYPE_2400：政府部门下发的其他有效证明文件
        /// CERTIFICATE_TYPE_2520：执业许可证/执业证
        /// CERTIFICATE_TYPE_2521：基层群众性自治组织特别法人统一社会信用代码证
        /// CERTIFICATE_TYPE_2522：农村集体经济组织登记证
        /// <para>示例值：CERTIFICATE_TYPE_2388</para>
        /// </remarks>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 营业执照扫描件
        /// </summary>
        /// <remarks>
        /// 1、主体为“个体工商户/企业”时，请上传营业执照的证件图片。
        /// 2、主体为“政府机关/事业单位/社会组织”时，请上传登记证书的证件图片。
        /// 3、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID 。
        /// 4、图片要求：
        /// （1）请上传证件的彩色扫描件或彩色数码拍摄件，黑白复印件需加盖公章（公章信息需完整） 。
        /// （2）不得添加无关水印（非微信支付商户申请用途的其他水印）。
        /// （3）需提供证件的正面拍摄件，完整、照面信息清晰可见。信息不清晰、扭曲、压缩变形、反光、不完整均不接受。
        /// （4）不接受二次剪裁、翻拍、PS的证件照片。
        /// <para>示例值：47ZC6GC-vnrbEny__Ie_An5-tCpqxucuxi-vByf3Gjm7KE53JXvGy9tqZm2XAUf-4KGprrKhpVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("business_license_copy")]
        public string BusinessLicenseCopy { get; set; }

        /// <summary>
        /// 营业执照注册号
        /// </summary>
        /// <remarks>
        /// 1、主体为“个体工商户/企业”时，请填写营业执照上的注册号/统一社会信用代码，须为18位数字|大写字母。
        /// 2、主体为“政府机关/事业单位/社会组织”时，请填写登记证书的证书编号。
        /// <para>示例值：123456789012345678</para>
        /// </remarks>
        [JsonPropertyName("business_license_number")]
        public string BusinessLicenseNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <remarks>
        /// 1、请填写营业执照/登记证书的商家名称，2~110个字符，支持括号 。
        /// 2、个体工商户/政府机关/事业单位/社会组织，不能以“公司”结尾。
        /// 3、个体工商户，若营业执照上商户名称为空或为“无”，请填写"个体户+经营者姓名"，如“个体户张三” 。
        /// <para>示例值：腾讯科技有限公司</para>
        /// </remarks>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 经营者/法定代表人姓名
        /// </summary>
        /// <remarks>
        /// 请填写证件的经营者/法定代表人姓名
        /// <para>示例值：张三</para>
        /// </remarks>
        [JsonPropertyName("legal_person")]
        public string LegalPerson { get; set; }

        /// <summary>
        /// 注册地址
        /// </summary>
        /// <remarks>
        /// 主体为“政府机关/事业单位/社会组织”时必填，请填写登记证书的注册地址。
        /// <para>示例值：深圳南山区科苑路</para>
        /// </remarks>
        [JsonPropertyName("company_address")]
        public string CompanyAddress { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        /// <remarks>
        /// 1、主体为“政府机关/事业单位/社会组织”时必填，请填写证件有效期。
        /// 2、若证件有效期为长期，请填写：长期。
        /// 3、结束时间需大于开始时间。
        /// <para>示例值：["2014-01-01","长期"]</para>
        /// </remarks>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }
    }
}
