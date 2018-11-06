using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIsvShopCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIsvShopCreateModel : AlipayObject
    {
        /// <summary>
        /// 地址。商户详细经营地址或人员所在地点
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店地址备注，如：地铁口左边
        /// </summary>
        [JsonProperty("address_memo")]
        [XmlElement("address_memo")]
        public string AddressMemo { get; set; }

        /// <summary>
        /// 门店实景图列表。最多3张，必须是实景图，不可有水印（如果上传装修效果图将驳回）。json格式字符串  支持格式：jpg/png/jpeg/bmp，单张图片不超过5MB，建议尺寸在2000*1500以上。
        /// </summary>
        [JsonProperty("attachment_list")]
        [XmlElement("attachment_list")]
        public string AttachmentList { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        [JsonProperty("business_time")]
        [XmlArray("business_time")]
        [XmlArrayItem("shop_business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 所选学校。指定门店类目下需要上传大学名称信息。  学校信息，请参考
        /// </summary>
        [JsonProperty("campus_name")]
        [XmlElement("campus_name")]
        public string CampusName { get; set; }

        /// <summary>
        /// 类目标签。选择部分门店类目时，必须要传此值。  比如：校园团餐类目  与类目的映射关系，请参考
        /// </summary>
        [JsonProperty("category_label")]
        [XmlElement("category_label")]
        public string CategoryLabel { get; set; }

        /// <summary>
        /// 城市编码，国标码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 店铺联系手机，与店铺联系固话二选一必填
        /// </summary>
        [JsonProperty("contact_mobile")]
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话，和店铺联系手机二选一必填
        /// </summary>
        [JsonProperty("contact_phone")]
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 区县编码，区县编码是与国家统计局一致，请查询: http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/ 国标省市区号下载：http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/2016.xls?spm=a219a.7629140.0.0.qRW4KQ&file=2016.xls
        /// </summary>
        [JsonProperty("district_code")]
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// ISV联系人手机号码
        /// </summary>
        [JsonProperty("isv_contact_mobile")]
        [XmlElement("isv_contact_mobile")]
        public string IsvContactMobile { get; set; }

        /// <summary>
        /// 联系人名字
        /// </summary>
        [JsonProperty("isv_contact_name")]
        [XmlElement("isv_contact_name")]
        public string IsvContactName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户id，表示将要开的店属于哪个商户。
        /// </summary>
        [JsonProperty("pid")]
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 省份编码，国标码。请查询:  http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/  国标省市区号下载：http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/2016.xls?spm=a219a.7629140.0.0.qRW4KQ&file=2016.xls
        /// </summary>
        [JsonProperty("province_code")]
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 资质证明图片。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key列表，json格式字符串，最多可以上传10张
        /// </summary>
        [JsonProperty("qualification_proof_list")]
        [XmlElement("qualification_proof_list")]
        public string QualificationProofList { get; set; }

        /// <summary>
        /// 资质证明类型。具体选值参见https://mif-pub.alipayobjects.com/QualificationType.xlsx
        /// </summary>
        [JsonProperty("qualification_proof_type")]
        [XmlElement("qualification_proof_type")]
        public string QualificationProofType { get; set; }

        /// <summary>
        /// 店铺类目，取值参见文件xxxxxxx
        /// </summary>
        [JsonProperty("shop_category")]
        [XmlElement("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺名称。直连开店要保证全局店铺名称+地址唯一
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [JsonProperty("shop_type")]
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
