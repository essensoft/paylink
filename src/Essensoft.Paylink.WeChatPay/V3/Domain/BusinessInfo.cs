using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 经营资料
    /// </summary>
    public class BusinessInfo : WeChatPayObject
    {
        /// <summary>
        /// 商户简称
        /// </summary>
        /// <remarks>
        /// 1、请输入2-30个字符，支持中文/字母/数字/特殊符号
        /// 2、在支付完成页向买家展示，需与微信经营类目相关；
        /// 3、简称要求
        /// （1）不支持单纯以人名来命名，若为个体户经营，可用“个体户+经营者名称”或“经营者名 称+业务”命名，如“个体户张三”或“张三餐饮店”；
        /// （2）不支持无实际意义的文案，如“XX特约商户”、“800”、“XX客服电话XXX”；
        /// <para>示例值：张三餐饮店</para>
        /// </remarks>
        [JsonPropertyName("merchant_shortname")]
        public string MerchantShortName { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        /// <remarks>
        /// 1、请填写真实有效的客服电话，将在交易记录中向买家展示，提供咨询服务；
        /// 2、请确保电话畅通，以便入驻后平台回拨确认。
        /// <para>示例值：0758XXXXX</para>
        /// </remarks>
        [JsonPropertyName("service_phone")]
        public string ServicePhone { get; set; }
    }
}
