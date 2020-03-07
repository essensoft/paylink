using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyInfoApplyModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyInfoApplyModel : AlipayObject
    {
        /// <summary>
        /// 委托书图片数据，根据biz_from参数确定是传base64字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("agent_auth_letter_picture")]
        public string AgentAuthLetterPicture { get; set; }

        /// <summary>
        /// 代理人证件图片辅助页图片，对应二代身份证就是国徽页，根据biz_from参数确定是传base64字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("agent_cert_card_assist_picture")]
        public string AgentCertCardAssistPicture { get; set; }

        /// <summary>
        /// 代理人证件信息页图片数据，对应二代身份证为带人脸页图片，根据biz_from参数确定是传base64字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("agent_cert_card_info_picture")]
        public string AgentCertCardInfoPicture { get; set; }

        /// <summary>
        /// 代理人证件图片有效期截止日期，"yyyy-MM-dd"格式，若为长期，则填“长期”
        /// </summary>
        [JsonPropertyName("agent_cert_expired_date")]
        public string AgentCertExpiredDate { get; set; }

        /// <summary>
        /// 代理人证件号码，若认证申请人不是法人而是代理人，则需要填写代理人相关信息
        /// </summary>
        [JsonPropertyName("agent_cert_no")]
        public string AgentCertNo { get; set; }

        /// <summary>
        /// 代理人证件类型，目前仅支持二代身份证：RESIDENT，不支持其他证件类型
        /// </summary>
        [JsonPropertyName("agent_cert_type")]
        public string AgentCertType { get; set; }

        /// <summary>
        /// 代理人姓名，若申请认证者非法人而是由代理人，则将代理人姓名填到此字段
        /// </summary>
        [JsonPropertyName("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 外部系统请求申请认证的业务来源，例如DingTalk，具体值请向认证开发同学确定
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 联系人手机号，用于认证过程中对用户进行短信通知的号码，11位数字
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 法人证件图片辅助页图片数据,若为身份证，则为国徽页图片，根据biz_from参数确定是传base64字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("legal_cert_card_assist_picture")]
        public string LegalCertCardAssistPicture { get; set; }

        /// <summary>
        /// 法定代表人的证件图片信息页数据，若为身份证，则为带人脸图片的那一页照片，根据biz_from参数确定是传base64字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("legal_cert_card_info_picture")]
        public string LegalCertCardInfoPicture { get; set; }

        /// <summary>
        /// 法定代表人证件有效期截止日期 “yyyy-MM-dd” 格式，若为长期，则填“长期”
        /// </summary>
        [JsonPropertyName("legal_cert_expired_date")]
        public string LegalCertExpiredDate { get; set; }

        /// <summary>
        /// 法定代表人证件号码
        /// </summary>
        [JsonPropertyName("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法定代表人证件类型  二代身份证：RESIDENT  护照:PASSPORT  港澳来往内地通行证：HONGKONG_MACAO  台湾同胞往来大陆通行证：TAIWAN
        /// </summary>
        [JsonPropertyName("legal_cert_type")]
        public string LegalCertType { get; set; }

        /// <summary>
        /// 法定代理人姓名，要按照营业执照上的姓名填写，必须一致，不能有错别字。
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 住所，填写营业执照号上的住所（经营地址）信息
        /// </summary>
        [JsonPropertyName("org_address")]
        public string OrgAddress { get; set; }

        /// <summary>
        /// 填写营业执照上的经营范围
        /// </summary>
        [JsonPropertyName("org_business_scope")]
        public string OrgBusinessScope { get; set; }

        /// <summary>
        /// 企业所在市，城市的中文完整描述
        /// </summary>
        [JsonPropertyName("org_city")]
        public string OrgCity { get; set; }

        /// <summary>
        /// 企业所在国家，目前只支持 中国
        /// </summary>
        [JsonPropertyName("org_country")]
        public string OrgCountry { get; set; }

        /// <summary>
        /// 营业执照上的经营期限截止日期，日期为10位格式"yyyy-MM-dd“  若为长期，则填“长期”
        /// </summary>
        [JsonPropertyName("org_main_cert_expired_date")]
        public string OrgMainCertExpiredDate { get; set; }

        /// <summary>
        /// 填企业营业执照上的注册号（一般为15位数字）或社会信用代码（18位数字加字母格式大写），如果有信用代码则优先填写社会信用代码
        /// </summary>
        [JsonPropertyName("org_main_cert_no")]
        public string OrgMainCertNo { get; set; }

        /// <summary>
        /// 营业执照图片信息，根据biz_from参数确定是要传base64编码格式的string字符串，还是传oss地址
        /// </summary>
        [JsonPropertyName("org_main_cert_picture")]
        public string OrgMainCertPicture { get; set; }

        /// <summary>
        /// 申请认证的公司的名字，要与营业执照上面一致，包括全半角字符
        /// </summary>
        [JsonPropertyName("org_name")]
        public string OrgName { get; set; }

        /// <summary>
        /// 企业所在省份，填写省份中文完整信息
        /// </summary>
        [JsonPropertyName("org_province")]
        public string OrgProvince { get; set; }

        /// <summary>
        /// 公司: ENTERPRISE，事业单位：PUBLIC_INST，社会团体：SOCIAL_ORG，民办非企业组织：PRIVATE_NON_ENTERPRISE，党政国家机关：PARTY_AND_STATE_ORGANS，个体工商户：INDIVIDUAL
        /// </summary>
        [JsonPropertyName("org_type")]
        public string OrgType { get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonPropertyName("register_capital")]
        public string RegisterCapital { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
