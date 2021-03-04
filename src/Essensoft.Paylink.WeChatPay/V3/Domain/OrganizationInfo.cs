using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 组织机构代码证
    /// </summary>
    public class OrganizationInfo : WeChatPayObject
    {
        /// <summary>
        /// 组织机构代码证照片
        /// </summary>
        /// <remarks>
        /// 可上传1张图片，请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GCGy9tqZm2XAUf-4KGprrKhpVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("organization_copy")]
        public string OrganizationCopy { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        /// <remarks>
        /// 1、请填写组织机构代码证上的组织机构代码。
        /// 2、可填写9或10位数字|字母|连字符。
        /// <para>示例值：123456789-A</para>
        /// </remarks>
        [JsonPropertyName("organization_code")]
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 组织机构代码证有效期开始日期
        /// </summary>
        /// <remarks>
        /// 1、请按照示例值填写。
        /// 2、证件有效期需大于60天。
        /// <para>示例值：2019-08-01</para>
        /// </remarks>
        [JsonPropertyName("org_period_begin")]
        public string OrgPeriodBegin { get; set; }

        /// <summary>
        /// 组织机构代码证有效期结束日期
        /// </summary>
        /// <remarks>
        /// 1、请按照示例值填写。
        /// 2、若证件有效期为长期，请填写：长期。
        /// 3、结束日期大于开始日期。
        /// 4、证件有效期需大于60天。
        /// <para>示例值：2019-08-01，长期</para>
        /// </remarks>
        [JsonPropertyName("org_period_end")]
        public string OrgPeriodEnd { get; set; }
    }
}
