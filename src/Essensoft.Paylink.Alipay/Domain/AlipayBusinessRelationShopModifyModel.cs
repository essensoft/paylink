using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopModifyModel Data Structure.
    /// </summary>
    public class AlipayBusinessRelationShopModifyModel : AlipayObject
    {
        /// <summary>
        /// 经营地址
        /// </summary>
        [JsonPropertyName("business_address")]
        public List<BusinessRelationShopAddresss> BusinessAddress { get; set; }

        /// <summary>
        /// 营业执照图片，需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id
        /// </summary>
        [JsonPropertyName("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，填写值为营业执照或统一社会信用代码证上的名称。<br>注意：<br>*若传入 cert_no，则本参数必填。
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 营业执照标号，<br>注意：<br>* 如果传了cert_image，则此字段必填
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。 <br>注意：<br>*若传入 cert_no，则本参数必填。
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商业关系门店手机号，与商业关系门店固话二选一必填
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 商业关系门店固话，和商业关系门店手机号二选一必填
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public List<BusinessRelationExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [JsonPropertyName("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [JsonPropertyName("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 门头照 id，需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id。<br>蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("out_door_images")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 商业关系门店门店id alipay.agent.marketing.business.relation.shop.create接口返回
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 商业关系门店logo ，和门头照二选一。  需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id。<br>蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("real_shop_logo")]
        public string RealShopLogo { get; set; }

        /// <summary>
        /// 外部门店编号，用于ISV系统内部门店标识等
        /// </summary>
        [JsonPropertyName("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 <a href="https://ur.alipay.com/4cmn0n">支付宝门店类目-最新</a> 表格。
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 代运营商业关系门店名称，即当前组织下可运营商业关系门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }
    }
}
