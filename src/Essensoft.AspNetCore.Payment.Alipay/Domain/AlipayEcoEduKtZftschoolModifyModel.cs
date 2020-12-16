using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtZftschoolModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEduKtZftschoolModifyModel : AlipayObject
    {
        /// <summary>
        /// 商户结算卡信息。本业务当前只允许传入一张结算卡
        /// </summary>
        [JsonPropertyName("biz_cards")]
        public List<SettleCardInfoKt> BizCards { get; set; }

        /// <summary>
        /// 学校地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [JsonPropertyName("business_address")]
        public AddressInfoKt BusinessAddress { get; set; }

        /// <summary>
        /// 商户证件图片url，格式jpg、jpeg、png   不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 证件反面图片URL，格式jpg、jpeg、png  。目前只有当主证件为身份证时才需填写
        /// </summary>
        [JsonPropertyName("cert_image_back")]
        public string CertImageBack { get; set; }

        /// <summary>
        /// 目前只有个体工商户商户类型要求填入本字段，填写值为个体工商户营业执照上的名称
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 商户证件编号（企业或者个体工商户提供营业执照，统一信用代码，事业单位提供事证号）  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 商户证件类型，201：营业执照；204 民办非企业单位登记证书；2011:营业执照(统一社会信用代码)；218：事业单位法人证书。   对应merchant_type规则，可参考： 01对应201或2011； 02对应218 办学许可证、事业单位法人证书、办园许可证、学前教育机构登记证、登记注册合格证； 03对应204 民办非企业单位登记证书  07对应 201 或 2011 
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 学校联系人信息。在本业务中，ContactInfo对象中名称，类型、手机号必填，其他选填
        /// </summary>
        [JsonPropertyName("contact_infos")]
        public List<ContactInfoKt> ContactInfos { get; set; }

        /// <summary>
        /// 开票资料信息
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public MerchantInvoiceInfoKt InvoiceInfo { get; set; }

        /// <summary>
        /// 此通知地址是为了保持教育缴费平台与ISV商户支付状态一致性。用户支付成功后，支付宝会根据本isv_notify_url，通过POST请求的形式将支付结果作为参数通知到商户系统，ISV商户可以根据返回的参数更新账单状态。  说明文档：https://docs.open.alipay.com/203/105286/  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("isv_notify_url")]
        public string IsvNotifyUrl { get; set; }

        /// <summary>
        /// 法人或负责人身份证反面URL，格式jpg、jpeg、png
        /// </summary>
        [JsonPropertyName("legal_cert_back_image")]
        public string LegalCertBackImage { get; set; }

        /// <summary>
        /// 法人或负责人身份证正面URL，格式jpg、jpeg、png
        /// </summary>
        [JsonPropertyName("legal_cert_front_image")]
        public string LegalCertFrontImage { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        [JsonPropertyName("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称，与证件上面一致
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 学校名和结算卡不一致时必填  学校授权函URL，格式jpg、jpeg、png
        /// </summary>
        [JsonPropertyName("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 商户类别码mcc，参见附件描述中的“类目code” https://mif-pub.alipayobjects.com/AlipayMCC.xlsx
        /// </summary>
        [JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 商家类型：01：企业；02：事业单位；03：民办非企业组织，07：个体工商户。   对应cert_type规则，可参考： 01对应201或2011； 02对应218 办学许可证、事业单位法人证书、办园许可；证、学前教育机构登记证、登记注册合格证 03对应204 民办非企业单位登记证书； 07对应 201 或 2011
        /// </summary>
        [JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 如果status为修改M，此项必填
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部订单号，ISV每次申请单生成，用于查询审核结果，创建时每个isv唯一标识，修改需和创建时保持一致
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 门头照URL，格式jpg、jpeg、png，该行业只支持一张
        /// </summary>
        [JsonPropertyName("out_door_images")]
        public List<string> OutDoorImages { get; set; }

        /// <summary>
        /// ISV的名称，用于缴费详情页面展示  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("partner_name")]
        public string PartnerName { get; set; }

        /// <summary>
        /// ISV联系电话,用于账单详情页面显示  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("partner_phone")]
        public string PartnerPhone { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("partner_pid")]
        public string PartnerPid { get; set; }

        /// <summary>
        /// 商户行业资质，教育缴费行业必填
        /// </summary>
        [JsonPropertyName("qualifications")]
        public List<IndustryQualificationInfoKt> Qualifications { get; set; }

        /// <summary>
        /// 学校名称，与证件一致，请核对后再提交
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// K12学校类型，1：代表托儿所； 2：代表幼儿园；3：代表小学；4：代表初中；5：代表高中。   如果学校兼有多种属性，可以连写，比如：   45：代表兼有初中部高中部；34：代表兼有小学部初中部  不可修改，请核对后再提交
        /// </summary>
        [JsonPropertyName("school_type")]
        public string SchoolType { get; set; }

        /// <summary>
        /// 商户使用服务，可选值有：当面付、app支付、wap支付、电脑支付，本行业wap支付必须填写
        /// </summary>
        [JsonPropertyName("service")]
        public List<string> Service { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 2018-10-01
        /// </summary>
        [JsonPropertyName("sign_time_with_isv")]
        public string SignTimeWithIsv { get; set; }

        /// <summary>
        /// 商户站点信息，包括网站、app、小程序。商户使用服务包含电脑支付或wap支付时，必须填充一个类型为01(网站)的SiteInfo对象；当包含app支付时，必须至少填充类型为02(APP)或06(支付宝小程序)中一种类型的SiteInfo对象
        /// </summary>
        [JsonPropertyName("sites")]
        public List<SiteInfoKt> Sites { get; set; }

        /// <summary>
        /// 修改还是创建，创建传C , 修改传M
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
