using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付、基础支付(服务商) - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请资金账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml">基础支付 - JSAPI支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml">基础支付 - APP支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml">基础支付 - H5支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml">基础支付 - Native支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml">基础支付 - 小程序支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_1_7.shtml">基础支付(服务商) - JSAPI支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_2_7.shtml">基础支付(服务商) - APP支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_3_7.shtml">基础支付(服务商) - H5支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_4_7.shtml">基础支付(服务商) - Native支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter4_5_7.shtml">基础支付(服务商) - 小程序支付 - 申请资金账单API</a> - 最新更新时间：2019.09.16</para>
    /// </remarks>
    public class WeChatPayBillFundflowBillQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 账单日期
        /// </summary>
        /// <remarks>
        /// 格式YYYY-MM-DD
        /// 仅支持三个月内的账单下载申请。
        /// <para>示例值：2019-06-11</para>
        /// </remarks>
        [JsonPropertyName("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 资金账户类型
        /// </summary>
        /// <remarks>
        /// 不填则默认是BASIC
        /// 枚举值：
        /// BASIC：基本账户
        /// OPERATION：运营账户
        /// FEES：手续费账户
        /// <para>示例值：BASIC</para>
        /// </remarks>
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 压缩类型
        /// </summary>
        /// <remarks>
        /// 不填则默认是数据流
        /// 枚举值：
        /// GZIP：返回格式为.gzip的压缩包账单
        /// <para>示例值：GZIP</para>
        /// </remarks>
        [JsonPropertyName("tar_type")]
        public string TarType { get; set; }
    }
}
