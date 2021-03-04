using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 营业执照
    /// </summary>
    public class BusinessLicenseInfo : WeChatPayObject
    {
        /// <summary>
        /// 营业执照照片
        /// </summary>
        /// <remarks>
        /// 1、可上传1张图片，请填写通过《图片上传API》预先生成的MediaID。
        /// 2、 请上传彩色照片or彩色扫描件or复印件（需加盖公章鲜章），可添加“微信支付”相关水印（如微信支付认证） 。
        /// <para>示例值：47ZC6GC-vnrbEny__Ie_An5-tCpqxucuxi-vByf3Gjm7KE53JXvGy9tqZm2XAUf-4KGprrKhpVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("license_copy")]
        public string LicenseCopy { get; set; }

        /// <summary>
        /// 注册号/统一社会信用代码
        /// </summary>
        /// <remarks>
        /// 请填写营业执照上的营业执照注册号，注册号格式须为15位数字或18位数字|大写字母。
        /// <para>示例值：123456789012345678</para>
        /// </remarks>
        [JsonPropertyName("license_number")]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        /// <remarks>
        /// 1、请填写营业执照上的商户名称，2~110个字符，支持括号。
        /// 2、个体户，不能以“公司”结尾。
        /// 3、个体户，若营业执照上商户名称为“空“或“无”时，填写"个体户+经营者姓名"，如“个体户张三”。
        /// <para>示例值：腾讯科技有限公司</para>
        /// </remarks>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 个体户经营者/法人姓名
        /// </summary>
        /// <remarks>
        /// 请填写营业执照的经营者/法定代表人姓名。
        /// <para>示例值：张三</para>
        /// </remarks>
        [JsonPropertyName("legal_person")]
        public string LegalPerson { get; set; }
    }
}
