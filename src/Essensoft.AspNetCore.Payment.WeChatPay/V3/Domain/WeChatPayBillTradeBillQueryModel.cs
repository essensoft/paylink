using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付 - JSAPI支付、APP支付、H5支付、Native支付、小程序支付 - 申请交易账单 - 请求URL参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_6.shtml">JSAPI支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_6.shtml">APP支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_6.shtml">H5支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_6.shtml">Native支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_6.shtml">小程序支付 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_1.shtml">账单 - 申请交易账单API</a> - 最新更新时间：2019.09.16</para>
    /// </remarks>
    public class WeChatPayBillTradeBillQueryModel : WeChatPayObject
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
        /// 二级商户号
        /// </summary>
        /// <remarks>
        /// 1、若商户是直连商户：无需填写该字段。
        /// 2、若商户是服务商：
        /// ● 不填则默认返回服务商下的交易或退款数据。
        /// ● 如需下载某个子商户下的交易或退款数据，则该字段必填。
        /// 特殊规则：最小字符长度为8
        /// 注意：仅适用于电商平台 服务商
        /// <para>示例值：1900000001</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 账单类型
        /// </summary>
        /// <remarks>
        /// 不填则默认是ALL
        /// 枚举值：
        /// ALL：返回当日所有订单信息（不含充值退款订单）
        /// SUCCESS：返回当日成功支付的订单（不含充值退款订单）
        /// REFUND：返回当日退款订单（不含充值退款订单）
        /// <para>示例值：ALL</para>
        /// </remarks>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

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
