using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 结算账户信息
    /// </summary>
    public class EcommerceAccountInfo : WeChatPayObject
    {
        /// <summary>
        /// 证件类型
        /// </summary>
        /// <remarks>
        /// 请填写受益人的证件类型。枚举值：
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
        [JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// 开户银行
        /// </summary>
        /// <remarks>
        /// 对私银行调用：查询支持个人业务的银行列表API
        /// 对公银行调用：查询支持对公业务的银行列表API。
        /// <para>示例值：工商银行</para>
        /// </remarks>
        [JsonPropertyName("account_bank")]
        public string AccountBank { get; set; }

        /// <summary>
        /// 开户名称
        /// </summary>
        /// <remarks>
        /// 1、选择经营者个人银行卡时，开户名称必须与身份证姓名一致。
        /// 2、选择对公账户时，开户名称必须与营业执照上的“商户名称”一致。
        /// 3、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值：AOZdYGISxo4y44/UgZ69bdu9X+tfMUJ9dl+LetjM45/zMbrYu+wWZ8gn4CTdo+D/m9MrPg+V4sm73oxqdQu/hj7aWyDl4GQtPXVdaztB9jVbVZh3QFzV+BEmytMNQp9dt1uWJktlfdDdLR3AMWyMB377xd+m9bSr/ioDTzagEcGe+vLYiKrzcroQv3OR0p3ppFYoQ3IfYeU/04S4t9rNFL+kyblK2FCCqQ11NdbbHoCrJc7NV4oASq6ZFonjTtgjjgKsadIKHXtb3JZKGZjduGdtkRJJp0/0eow96uY1Pk7Rq79Jtt7+I8juwEc4P4TG5xzchG/5IL9DBd+Z0zZXkw==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 开户银行省市编码
        /// </summary>
        /// <remarks>
        /// 至少精确到市，详细参见省市区编号对照表。
        /// 注：
        /// 仅当省市区编号对照表中无对应的省市区编号时，可向上取该银行对应市级编号或省级编号。
        /// <para>示例值：110000</para>
        /// </remarks>
        [JsonPropertyName("bank_address_code")]
        public string BankAddressCode { get; set; }

        /// <summary>
        /// 开户银行联行号
        /// </summary>
        /// <remarks>
        /// 1、根据开户银行查询接口中的“是否需要填写支行”判断是否需要填写。如为其他银行，开户银行全称（含支行）和开户银行联行号二选一。
        /// 2、详细需调用查询支行列表API查看查询结果。
        /// <para>示例值：402713354941</para>
        /// </remarks>
        [JsonPropertyName("bank_branch_id")]
        public string BankBranchId { get; set; }

        /// <summary>
        /// 开户银行全称 （含支行）
        /// </summary>
        /// <remarks>
        /// 1、根据开户银行查询接口中的“是否需要填写支行”判断是否需要填写。如为其他银行，开户银行全称（含支行）和开户银行联行号二选一。
        /// 2、详细需调用查询支行列表API查看查询结果。
        /// <para>示例值：中国工商银行股份有限公司北京市分行营业部</para>
        /// </remarks>
        [JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        /// <remarks>
        /// 1、数字，长度遵循系统支持的对公/对私卡号长度要求表。
        /// 2、该字段需进行加密处理，加密方法详见敏感信息加密说明。(提醒：必须在HTTP头中上送Wechatpay-Serial)
        /// <para>示例值： d+xT+MQCvrLHUVDWv/8MR/dB7TkXLVfSrUxMPZy6jWWYzpRrEEaYQE8ZRGYoeorwC+w==</para>
        /// </remarks>
        [WeChatPayPrivacyProperty]
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 银行账户证明材料
        /// </summary>
        /// <remarks>
        ///1. 当主体类型是“政府机关/事业单位”时或所属行业为“党费”时，支持在有合法资金管理关系的情况下结算账户设置为非同名。
        ///2. 若结算账户设置为非同名，则需填写非同名证明材料，若结算账户为同名，则无需填写。
        /// </remarks>
        [JsonPropertyName("account_cert_info")]
        public AccountCertInfo AccountCertInfo { get; set; }
    }
}
