using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectZftCreateModel : AlipayObject
    {
        /// <summary>
        /// 商户别名。支付宝账单中的商户名称会展示此处设置的别名，如果涉及支付宝APP内的支付，支付结果页也会展示该别名
        /// </summary>
        [JsonPropertyName("alias_name")]
        public string AliasName { get; set; }

        /// <summary>
        /// 结算支付宝账号，结算账号使用支付宝账号时必填。本字段要求与商户名称name同名，且是实名认证支付宝账户(个体工商户可以与name或cert_name相同)
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 签约支付宝账户，用于协议确认，及后续二级商户增值产品服务签约时使用。本字段要求与商户名称name同名，且是实名认证支付宝账户
        /// </summary>
        [JsonPropertyName("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 结算银行卡，如果结算到支付宝账号，则不需要填写。本业务当前只允许传入一张结算卡
        /// </summary>
        [JsonPropertyName("biz_cards")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 经营地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [JsonPropertyName("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 商户证件图片url，本业务接口中，如果是特殊行业必填。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。
        /// </summary>
        [JsonPropertyName("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件反面图片。目前只有当商户类型是个人商户，主证件为身份证时才需填写
        /// </summary>
        [JsonPropertyName("cert_image_back")]
        public string CertImageBack { get; set; }

        /// <summary>
        /// 目前只有个体工商户商户类型要求填入本字段，填写值为个体工商户营业执照上的名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 商户证件编号，按商户类型merchant_type的说明提供对应的证件编号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商户证件类型，按商户类型merchant_type的说明提供对应的证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 商户联系人信息。在本业务中，ContactInfo对象中联系人姓名，联系人类型、手机号必填，其他选填
        /// </summary>
        [JsonPropertyName("contact_infos")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 默认结算规则。当调用收单接口，结算条款中设置默认结算规则时，交易资金将结算至此处设置的默认结算目标账户中。其详细描述及收单接口传参示例参考功能包文档
        /// </summary>
        [JsonPropertyName("default_settle_rule")]
        public DefaultSettleRule DefaultSettleRule { get; set; }

        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 开票资料信息
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public MerchantInvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 法人身份证反面url，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。本业务接口中，如果是特殊行业必填
        /// </summary>
        [JsonPropertyName("legal_cert_back_image")]
        public string LegalCertBackImage { get; set; }

        /// <summary>
        /// 法人身份证正面url，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。本业务接口中，如果是特殊行业必填
        /// </summary>
        [JsonPropertyName("legal_cert_front_image")]
        public string LegalCertFrontImage { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [JsonPropertyName("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 默认可不填，认为legal_cert_no是大陆身份证。类型包括：100 大陆身份证；105 港澳居民往来内地通行证；106 台湾同胞往来大陆通行证；108 外国人居留证
        /// </summary>
        [JsonPropertyName("legal_cert_type")]
        public string LegalCertType { get; set; }

        /// <summary>
        /// 法人名称
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 授权函。其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。当商户名与结算卡户名不一致（模板参考https://gw.alipayobjects.com/os/skylark-tools/public/files/d5fcbe7463d7159a0d362da417d157ed.docx），或涉及外籍法人（这种情况上传任意能证明身份的图片）时必填
        /// </summary>
        [JsonPropertyName("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 商户类别码mcc，参见https://gw.alipayobjects.com/os/bmw-prod/05c9a32e-42d1-436b-ace7-13101d91f672.xlsx 特殊行业要按照MCC说明中的资质一栏上传辅助资质，辅助资质要在qualifications中上传，会有人工审核。
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商户类型： 01：企业；cert_type填写201（营业执照）；cert_no填写营业执照号； 02：事业单位：cert_type填写218（事业单位法人证书）；cert_no填写事业单位法人证书编号； 03：民办非企业组织：cert_type填写204（民办非企业登记证书）；cert_no填写民办非企业登记证书编号； 04：社会团体：cert_type填写206（社会团体法人登记证书）；cert_no填写社会团体法人登记证书编号； 05：党政及国家机关：cert_type填写219（党政机关批准设立文件/行政执法主体资格证）；cert_no填写党政机关批准设立文件/行政执法主体资格证编号； 06：个人商户：cert_type填写100（个人身份证）；cert_no填写个人身份证号码； 07：个体工商户：cert_type填写201（营业执照）；cert_no填写营业执照编号；
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 进件的二级商户名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部业务号。比如某种业务标准外部订单号,比如交易外部订单号，代表服务商端自己订单号。用于做并发控制，防止一笔外部订单发起两次进件。非必要场景禁止传入本字段，如要使用务必理清场景及字段生成规则，与蚂蚁金服对接人咨询。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 门头照，其值为使用ant.merchant.expand.indirect.image.upload上传图片得到的一串oss key。如果使用当面付服务则必填
        /// </summary>
        [JsonPropertyName("out_door_images")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// 商户行业资质，当商户是特殊行业时必填
        /// </summary>
        [JsonPropertyName("qualifications")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 商户使用服务，可选值有：当面付、app支付、wap支付、电脑支付
        /// </summary>
        [JsonPropertyName("service")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 二级商户与服务商的签约时间
        /// </summary>
        [JsonPropertyName("sign_time_with_isv")]
        public string SignTimeWithIsv { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。商户使用服务包含电脑支付或wap支付时，必须填充一个类型为01(网站)的SiteInfo对象，site_type/site_url/site_name必填；当包含app支付时，必须至少填充类型为02(APP)或06(支付宝小程序)中一种类型的SiteInfo对象，site_type/site_name必填
        /// </summary>
        [JsonPropertyName("sites")]
        public List<SiteInfo> Sites { get; set; }
    }
}
