using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementSignModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementSignModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝登录账号，支持邮箱或手机号码格式。  本参数与alipay_user_id不可同时为空，若都填写，则以alipay_user_id为准。
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 用户的支付宝id，本参数与alipay_logon_id不可同时为空，若都填写，则以本参数为准，优先级高于alipay_logon_id。
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 资产信息，针对于泛金融机构，签约时必须传入资产信息。json格式。
        /// </summary>
        [JsonPropertyName("asset_params")]
        public AssetParams AssetParams { get; set; }

        /// <summary>
        /// 支付宝账户绑定的手机，系统会对账户绑定的手机与传入的手机号做一致性校验。  商户调用必传。  阿里集团内部调用，可不传。
        /// </summary>
        [JsonPropertyName("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 签约确认方式，用户进行协议签约时的确认方式，不同产品所支持的确认方式不同。  目前仅支持如下两类：  M：手机校验码回填确认方式。  如果为空，则默认为无需用户确认。
        /// </summary>
        [JsonPropertyName("confirm_type")]
        public string ConfirmType { get; set; }

        /// <summary>
        /// 设备信息参数，在使用设备维度签约代扣协议时，可以传这些信息
        /// </summary>
        [JsonPropertyName("device_params")]
        public DeviceParams DeviceParams { get; set; }

        /// <summary>
        /// 商户签约号，代扣协议中标示用户的唯一签约号（确保在商户系统中唯一）。  格式规则：支持大写小写字母和数字，最长32位。  商户系统按需传入，如果同一用户在同一产品码、同一签约场景下，签订了多份代扣协议，那么需要指定并传入该值。
        /// </summary>
        [JsonPropertyName("external_agreement_no")]
        public string ExternalAgreementNo { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号，用于在签约页面展示，如果为空，则不展示
        /// </summary>
        [JsonPropertyName("external_logon_id")]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 个人签约产品码，商户和支付宝签约时确定，商户可咨询技术支持。
        /// </summary>
        [JsonPropertyName("personal_product_code")]
        public string PersonalProductCode { get; set; }

        /// <summary>
        /// 签约产品属性，json格式
        /// </summary>
        [JsonPropertyName("prod_params")]
        public ProdParams ProdParams { get; set; }

        /// <summary>
        /// 销售产品码，商户签约的支付宝合同所对应的产品码。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 签约营销参数，此值为json格式；具体的key需与营销约定
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 卡id(由固定前缀+32位数字构成)
        /// </summary>
        [JsonPropertyName("provisioning_bundle_id")]
        public string ProvisioningBundleId { get; set; }

        /// <summary>
        /// 协议签约场景，商户和支付宝签约时确定，商户可咨询技术支持。  当传入商户签约号external_sign_no时，场景不能为默认值DEFAULT|DEFAULT。
        /// </summary>
        [JsonPropertyName("sign_scene")]
        public string SignScene { get; set; }

        /// <summary>
        /// 当前用户签约请求的协议有效周期。  整形数字加上时间单位的协议有效期，从发起签约请求的时间开始算起。  目前支持的时间单位：  1. d：天  2. m：月  如果未传入，默认为长期有效。
        /// </summary>
        [JsonPropertyName("sign_validity_period")]
        public string SignValidityPeriod { get; set; }

        /// <summary>
        /// 此参数用于传递子商户信息，目前商户代扣、海外代扣、淘旅行信用住产品支持传入该参数(销售方案中是否允许自定义子商户信息选是)；  目前支持四个key值：  sub_merchant_id (子商户id)  sub_merchant_name (子商户名称)  sub_merchant_service_name (子商户服务名称)  sub_merchant_service_description (子商户服务描述)
        /// </summary>
        [JsonPropertyName("sub_merchant")]
        public string SubMerchant { get; set; }

        /// <summary>
        /// 签约第三方主体类型。对于三方协议，表示当前用户和哪一类的第三方主体进行签约。  取值范围：  1. PARTNER（平台商户）  2. MERCHANT（集团商户），集团下子商户可共享用户签约内容  默认为PARTNER。
        /// </summary>
        [JsonPropertyName("third_party_type")]
        public string ThirdPartyType { get; set; }

        /// <summary>
        /// 商户希望限制的签约用户的年龄范围，min表示可签该协议的用户年龄下限，max表示年龄上限。如{"min": "18","max": "30"}表示18=<年龄<=30的用户可以签约该协议。
        /// </summary>
        [JsonPropertyName("user_age_range")]
        public string UserAgeRange { get; set; }

        /// <summary>
        /// 校验信息，针对双因子校验逻辑，如果logonId为email时，必须传入证件号后4位信息。Json格式。
        /// </summary>
        [JsonPropertyName("verify_params")]
        public VerifyParams VerifyParams { get; set; }

        /// <summary>
        /// 芝麻授权信息，针对于信用代扣签约。json格式。
        /// </summary>
        [JsonPropertyName("zm_auth_params")]
        public ZmAuthParams ZmAuthParams { get; set; }
    }
}
