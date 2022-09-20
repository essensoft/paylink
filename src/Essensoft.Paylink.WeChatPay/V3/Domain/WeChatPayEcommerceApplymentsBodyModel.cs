using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    public class WeChatPayEcommerceApplymentsBodyModel : WeChatPayObject
    {
        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 1、服务商自定义的商户唯一编号。
        /// 2、每个编号对应一个申请单，每个申请单审核通过后会生成一个微信支付商户号。
        /// 3、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息 。
        /// <para>示例值：APPLYMENT_00000000001</para>
        /// </remarks>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }


        /// <summary>
        /// 主体类型
        /// </summary>
        /// <remarks>
        /// 非小微的主体类型需与营业执照/登记证书上一致，可参考选择主体指引，枚举值如下。
        /// 2401：小微商户，指无营业执照的个人商家。
        /// 2500：个人卖家，指无营业执照，已持续从事电子商务经营活动满6个月，且期间经营收入累计超过20万元的个人商家。（若选择该主体，请在“补充说明”填写相关描述）。
        /// 4：个体工商户，营业执照上的主体类型一般为个体户、个体工商户、个体经营。
        /// 2：企业，营业执照上的主体类型一般为有限公司、有限责任公司。
        /// 3：事业单位，包括国内各类事业单位，如：医疗、教育、学校等单位。
        /// 2502：政府机关，包括各级、各类政府机关，如机关党委、税务、民政、人社、工商、商务、市监等。
        /// 1708：社会组织，包括社会团体、民办非企业、基金会、基层群众性自治组织、农村集体经济组织等组织。
        /// <para>示例值：2</para>
        /// </remarks>
        [JsonPropertyName("organization_type")]
        public string OrganizationType { get; set; }

        /// <summary>
        /// 是否金融机构
        /// </summary>
        /// <remarks>
        /// 选填，请根据申请主体的实际情况填写，可参考选择金融机构指引
        /// 1、若商户主体是金融机构，则填写：true。
        /// 2、若商户主体不是金融机构，则填写：false。
        /// 若未传入将默认填写：false。
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("finance_institution")]
        public bool? FinanceInstitution { get; set; }

        /// <summary>
        /// 营业执照/登记证书信息
        /// </summary>
        /// <remarks>
        /// 1、主体为“小微/个人卖家”时，不填。
        /// 2、主体为“个体工商户/企业”时，请上传营业执照。
        /// 3、主体为“政府机关/事业单位/社会组织”时，请上传登记证书。
        /// </remarks>
        [JsonPropertyName("business_license_info")]
        public EcommerceBusinessLicenceInfo EcommerceBusinessLicenceInfo { get; set; }

        /// <summary>
        /// 金融机构许可证信息
        /// </summary>
        /// <remarks>
        /// 当主体是金融机构时，必填
        /// </remarks>
        [JsonPropertyName("finance_institution_info")]
        public EcommerceFinanceInstitutionInfo EcommerceFinanceInstitutionInfo { get; set; }

        /// <summary>
        /// 证件持有人类型
        /// </summary>
        /// <remarks>
        /// 1. 主体类型为政府机关/事业单位时选传：
        /// （1）若上传的是法人证件，则不需要上传该字段。
        /// （2）若因特殊情况，无法提供法人证件时，可上传经办人。 （经办人：经商户授权办理微信支付业务的人员，授权范围包括但不限于签约，入驻过程需完成账户验证）。
        /// 2. 主体类型为企业/个体户/社会组织时，默认为经营者/法人，不需要上传该字段。
        /// LEGAL：法人
        /// SUPER：经办人
        /// <para>示例值：LEGAL</para>
        /// </remarks>
        [JsonPropertyName("id_holder_type")]
        public string IdHolderType { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        /// <remarks>
        /// 1、当证件持有人类型为法人时，填写。其他情况，无需上传。
        /// 2、个体户/企业/事业单位/社会组织：可选择任一证件类型，政府机关仅支持中国大陆居民-身份证类型。
        /// IDENTIFICATION_TYPE_IDCARD：中国大陆居民-身份证
        /// IDENTIFICATION_TYPE_OVERSEA_PASSPORT：其他国家或地区居民-护照
        /// IDENTIFICATION_TYPE_HONGKONG_PASSPORT：中国香港居民-来往内地通行证
        /// IDENTIFICATION_TYPE_MACAO_PASSPORT：中国澳门居民-来往内地通行证
        /// IDENTIFICATION_TYPE_TAIWAN_PASSPORT：中国台湾居民-来往大陆通行证
        /// IDENTIFICATION_TYPE_FOREIGN_RESIDENT：外国人居留证
        /// IDENTIFICATION_TYPE_HONGKONG_MACAO_RESIDENT：港澳居民证
        /// IDENTIFICATION_TYPE_TAIWAN_RESIDENT：台湾居民证
        /// <para>示例值：IDENTIFICATION_TYPE_IDCARD</para>
        /// </remarks>
        [JsonPropertyName("id_doc_type")]
        public string IdDocType { get; set; }

        /// <summary>
        /// 法定代表人说明函
        /// </summary>
        /// <remarks>
        /// 1、当证件持有人类型为经办人时，必须上传。其他情况，无需上传。
        /// 2、若因特殊情况，无法提供法定代表人证件时，请参照示例图打印法定代表人说明函，全部信息需打印，不支持手写商户信息，并加盖公章。
        /// 3、可上传1张图片，请填写通过图片上传APIAPI预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("authorize_letter_copy")]
        public string AuthorizeLetterCopy { get; set; }

        /// <summary>
        /// 身份证信息
        /// </summary>
        /// <remarks>
        /// 当证件持有人类型为经营者/法人且证件类型为“身份证”时填写。
        /// </remarks>
        [JsonPropertyName("id_card_info")]
        public EcommerceIdCardInfo EcommerceIdCardInfo { get; set; }

        /// <summary>
        /// 其他类型证件信息
        /// </summary>
        /// <remarks>
        /// 当证件持有人类型为经营者/法人且证件类型不为“身份证”时填写。
        /// </remarks>
        [JsonPropertyName("id_doc_info")]
        public IdDocInfo IdDocInfo { get; set; }

        /// <summary>
        /// 经营者/法人是否为受益人
        /// </summary>
        /// <remarks>
        /// 主体类型为企业时，需要填写：
        /// 1、若经营者/法人是最终受益人，则填写：true。
        /// 2、若经营者/法人不是最终受益人，则填写：false。
        /// <para>示例值：true</para>
        /// </remarks>
        [JsonPropertyName("owner")]
        public bool Owner { get; set; }

        /// <summary>
        /// 最终受益人信息(UBO]
        /// </summary>
        /// <remarks>
        /// 仅企业需要填写。
        /// 若经营者/法人不是最终受益所有人，则需补充受益所有人信息，最多上传4个。
        /// 若经营者/法人是最终受益所有人之一，可在此添加其他受益所有人信息，最多上传3个。
        /// 根据国家相关法律法规，需要提供公司受益所有人信息，受益所有人需符合至少以下条件之一：
        /// 1、直接或者间接拥有超过25%公司股权或者表决权的自然人。
        /// 2、通过人事、财务等其他方式对公司进行控制的自然人。
        /// 3、公司的高级管理人员，包括公司的经理、副经理、财务负责人、上市公司董事会秘书和公司章程规定的其他人员。
        /// </remarks>
        [JsonPropertyName("ubo_info_list")]
        public List<EcommerceUboInfo> UboInfoList { get; set; }

        /// <summary>
        /// 结算账户信息
        /// </summary>
        [JsonPropertyName("account_info")]
        public EcommerceAccountInfo AccountInfo { get; set; }

        /// <summary>
        /// 超级管理员信息
        /// </summary>
        [JsonPropertyName("contact_info")]
        public EcommerceContactInfo EcommerceContactInfo { get; set; }

        /// <summary>
        /// 店铺信息
        /// </summary>
        [JsonPropertyName("sales_scene_info")]
        public EcommerceSalesSceneInfo EcommerceSalesSceneInfo { get; set; }

        /// <summary>
        /// 结算规则
        /// </summary>
        /// <remarks>
        /// 请填写商家的结算费率规则、所属行业等信息。若电商平台未传入，系统将填写默认值
        /// </remarks>
        [JsonPropertyName("settlement_info")]
        public EcommerceSettlementInfo EcommerceSettlementInfo { get; set; }

        /// <summary>
        /// 商户简称
        /// </summary>
        /// <remarks>
        /// UTF-8格式，中文占3个字节，即最多21个汉字长度。将在支付完成页向买家展示，需与商家的实际售卖商品相符 。
        /// <para>示例值：腾讯</para>
        /// </remarks>
        [JsonPropertyName("merchant_shortname")]
        public string MerchantShortname { get; set; }

        /// <summary>
        /// 特殊资质
        /// </summary>
        /// <remarks>
        /// 1、根据商户经营业务要求提供相关资质，详情查看《行业对应特殊资质》。
        /// 2、请提供为“申请商家主体”所属的特殊资质，可授权使用总公司/分公司的特殊资 质；
        /// 3、最多可上传5张照片，请填写通过图片上传接口预先上传图片生成好的MediaID 。
        /// <para>示例值：[\"jTpGmxUX3FBWVQ5NJInE4d2I6_H7I4\"]</para>
        /// </remarks>
        [JsonPropertyName("qualifications")]
        public string Qualifications { get; set; }

        /// <summary>
        /// 补充材料
        /// </summary>
        /// <remarks>
        /// 根据实际审核情况，额外要求提供。最多可上传5张照片，请填写通过图片上传接口预先上传图片生成好的MediaID 。
        /// <para>示例值：[\"jTpGmg05InE4d2I6_H7I4\"]</para>
        /// </remarks>
        [JsonPropertyName("business_addition_pics")]
        public string BusinessAdditionPics { get; set; }

        /// <summary>
        /// 补充说明
        /// </summary>
        /// <remarks>
        /// 1、若主体为“个人卖家”，该字段必传，则需填写描述“ 该商户已持续从事电子商务经营活动满6个月，且期间经营收入累计超过20万元。”
        /// <para>示例值：特殊情况，说明原因</para>
        /// </remarks>
        [JsonPropertyName("business_addition_desc")]
        public string BusinessAdditionDesc { get; set; }
    }
}

