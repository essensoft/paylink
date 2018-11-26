using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LegalRepresentativeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LegalRepresentativeInfo : AlipayObject
    {
        /// <summary>
        /// 法人证件有效期，YYYY-MM-DD格式
        /// </summary>
        [JsonProperty("legal_representative_cert_indate")]
        [XmlElement("legal_representative_cert_indate")]
        public string LegalRepresentativeCertIndate { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [JsonProperty("legal_representative_cert_no")]
        [XmlElement("legal_representative_cert_no")]
        public string LegalRepresentativeCertNo { get; set; }

        /// <summary>
        /// 法人证件背面照片（如证件为身份证则上传身份证国徽面图片）
        /// </summary>
        [JsonProperty("legal_representative_cert_pic_back")]
        [XmlElement("legal_representative_cert_pic_back")]
        public string LegalRepresentativeCertPicBack { get; set; }

        /// <summary>
        /// 法人证件正面照片（如证件为身份证则上传身份证头像面图片）
        /// </summary>
        [JsonProperty("legal_representative_cert_pic_front")]
        [XmlElement("legal_representative_cert_pic_front")]
        public string LegalRepresentativeCertPicFront { get; set; }

        /// <summary>
        /// 法人证件类型，支持传入的类型为：RESIDENT(居民身份证)括号中为每种类型的释义，不需要将括号中的内容当参数内容传入。
        /// </summary>
        [JsonProperty("legal_representative_cert_type")]
        [XmlElement("legal_representative_cert_type")]
        public string LegalRepresentativeCertType { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("legal_representative_name")]
        [XmlElement("legal_representative_name")]
        public string LegalRepresentativeName { get; set; }
    }
}
