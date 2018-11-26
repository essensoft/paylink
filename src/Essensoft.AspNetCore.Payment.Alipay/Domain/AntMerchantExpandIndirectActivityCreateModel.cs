using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectActivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动类型，间联商户报名的支付宝活动类型。  蓝海行动：BLUE_SEA
        /// </summary>
        [JsonProperty("activity_type")]
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 商户简称，门头照的名称或者大众点评、美团、饿了么、口碑、百度外卖入驻平台名称。需和进件时别名保持一致。
        /// </summary>
        [JsonProperty("alias_name")]
        [XmlElement("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 营业执照，要求营业执照文本信息清晰可见。  其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("business_license_pic")]
        [XmlElement("business_license_pic")]
        public string BusinessLicensePic { get; set; }

        /// <summary>
        /// 收银台照片，必须包含：①主扫：扫码支付场景需要展示具有支付宝logo和“推荐使用支付宝 或 支付就用支付宝”露出的二维码物料或立牌；②被扫：展示具有支付宝logo和“推荐使用支付宝 或 支付就用支付宝”的扫码机具（盒子）  其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("checkstand_pic")]
        [XmlElement("checkstand_pic")]
        public string CheckstandPic { get; set; }

        /// <summary>
        /// 店内环境照，要求照片清晰可见。  其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("indoor_pic")]
        [XmlElement("indoor_pic")]
        public string IndoorPic { get; set; }

        /// <summary>
        /// 商户名称，营业执照上的名称，需和进件名称保持一致。
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 主流餐饮平台入驻证明（任选一个即可）：大众点评、美团、饿了么、口碑、百度外卖餐饮平台商户展示页面。  其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("settled_pic")]
        [XmlElement("settled_pic")]
        public string SettledPic { get; set; }

        /// <summary>
        /// 门头照。  其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonProperty("shop_entrance_pic")]
        [XmlElement("shop_entrance_pic")]
        public string ShopEntrancePic { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
