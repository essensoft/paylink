using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateAuthenticateCampuscardModifyModel : AlipayObject
    {
        /// <summary>
        /// 校区
        /// </summary>
        [JsonProperty("campus")]
        public string Campus { get; set; }

        /// <summary>
        /// 学工号
        /// </summary>
        [JsonProperty("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 一卡通卡号（实体卡）
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 1有效，2无效，3挂失
        /// </summary>
        [JsonProperty("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 1学生卡，2教工卡，3临时卡，4其他
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 学生证件号
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 学生证件类型，默认为1: 1 居民身份证
        /// </summary>
        [JsonProperty("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 一卡通芯片号
        /// </summary>
        [JsonProperty("chip_no")]
        public string ChipNo { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 有效期，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("expire_at")]
        public string ExpireAt { get; set; }

        /// <summary>
        /// 扩展信息，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 学生性别,0未知，1男，2女，9未说明的性别
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// base64编码人脸照片
        /// </summary>
        [JsonProperty("image_base_64")]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// 人脸采集时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonProperty("image_date")]
        public string ImageDate { get; set; }

        /// <summary>
        /// 学生/教职工在学校唯一短号，由isv分配
        /// </summary>
        [JsonProperty("isv_short_code")]
        public string IsvShortCode { get; set; }

        /// <summary>
        /// 学生手机
        /// </summary>
        [JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 学生/教职工姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 组织信息,多个分组以;隔开：AA/BB/CC;A/B/C
        /// </summary>
        [JsonProperty("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonProperty("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校标识码
        /// </summary>
        [JsonProperty("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 学生/教职工在学校唯一短号，此字段废弃
        /// </summary>
        [JsonProperty("short_code")]
        public long ShortCode { get; set; }
    }
}
