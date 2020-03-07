using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertdocSyncModel Data Structure.
    /// </summary>
    public class AlipayUserCertdocSyncModel : AlipayObject
    {
        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// IDENTITY_CARD:身份证;  DRIVING_LICENSE:驾驶证;  VEHICLE_LICENSE:行驶证;  SOCIAL_SECURITY_CARD:社会保障卡;  PASSPORT:护照;  DEGREE_CERTIFICATE:学位证;  HK_MACAU_LAISSEZ_PASSER:港澳通行证;  PROPRETY_OWNERSHIP_CERTIFICATE:房产证;  REAL_ESTATE_WARRANTS:不动产证;
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 证件其余信息,以json string形式传入。具体每一个k/v规则参照具体证件规则。举例驾驶证extInfo规则：  字段名字(key):drivingLicenseNo,字段含义:证号,字段类型:STRING,是否可空:否;  字段名字(key):sex,字段含义:性别,字段类型:STRING,是否可空:是,值非空时约束:选择,具体约束:男,女,;  字段名字(key):nationality,字段含义:国籍,字段类型:STRING,是否可空:是;  字段名字(key):address,字段含义:住址,字段类型:STRING,是否可空:是;  字段名字(key):dateOfBirth,字段含义:出生日期,字段类型:DATE,是否可空:是;  字段名字(key):dateOfFirstIssue,字段含义:初次领证日期,字段类型:DATE,是否可空:是;  字段名字(key):clazz,字段含义:准驾车型,字段类型:STRING,是否可空:是,值非空时约束:正则表达式,具体约束:^[a-z_A-Z_0-9]*$;  字段名字(key):fileNo,字段含义:档案编号,字段类型:STRING,是否可空:是,值非空时约束:正则表达式,具体约束:^[0-9]{12}$;  字段名字(key):issuingAuthority,字段含义:签发机关,字段类型:STRING,是否可空:是;  字段名字(key):valideDate,字段含义:生效日期,字段类型:DATE,是否可空:是,值非空时约束:正则表达式,具体约束:^\d{4}-\d{2}-\d{2}$;  字段名字(key):expireDate,字段含义:失效日期,字段类型:DATE,是否可空:是,值非空时约束:正则表达式,具体约束:^\d{4}-\d{2}-\d{2}$;
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 证件主体用户姓名。证件类型+证件号+证件姓名需要唯一。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证件图片集合
        /// </summary>
        [JsonPropertyName("pic_list")]
        public List<OpenCertPic> PicList { get; set; }

        /// <summary>
        /// 证件状态，T或者空代表正常，F代表删除。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
