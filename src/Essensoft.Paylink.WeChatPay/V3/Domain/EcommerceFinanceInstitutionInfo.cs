using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 金融机构许可证信息
    /// </summary>
    public class EcommerceFinanceInstitutionInfo : WeChatPayObject
    {
        /// <summary>
        /// 金融机构类型
        /// </summary>
        /// <remarks>
        /// 金融机构类型需与营业执照/登记证书上一致，可参考选择金融机构指引。
        /// BANK_AGENT：银行业, 适用于商业银行、政策性银行、农村合作银行、村镇银行、开发性金融机构等
        /// PAYMENT_AGENT：支付机构, 适用于非银行类支付机构
        /// INSURANCE：保险业, 适用于保险、保险中介、保险代理、保险经纪等保险类业务
        /// TRADE_AND_SETTLE：交易及结算类金融机构, 适用于交易所、登记结算类机构、银行卡清算机构、资金清算中心等
        /// OTHER：其他金融机构, 适用于财务公司、信托公司、金融资产管理公司、金融租赁公司、汽车金融公司、贷款公司、货币经纪公司、消费金融公司、证券业、金融控股公司、股票、期货、货币兑换、小额贷款公司、金融资产管理、担保公司、商业保理公司、典当行、融资租赁公司、财经咨询等其他金融业务
        /// <para>示例值：BANK_AGENT</para>
        /// </remarks>
        [JsonPropertyName("finance_type")]
        public string FinanceType { get; set; }

        /// <summary>
        /// 金融机构许可证图片
        /// </summary>
        /// <remarks>
        /// 1、根据所属金融机构类型的许可证要求提供，详情查看金融机构指引。
        /// 2、请提供为“申请商家主体”所属的许可证，可授权使用总公司/分公司的特殊资质。
        /// 3、最多可上传5张照片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny__Ie_An5-tCpqxucuxi-vByf3Gjm7KE53JXvGy9tqZm2XAUf-4KGprrKhpVBDIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("finance_license_pics")]
        public List<string> FinanceLicensePics { get; set; }
    }
}
