using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 账单-申请交易账单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2019.09.16
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_1.shtml
    /// </summary>
    public class WeChatPayBillTradeBillRequest : IWeChatPayGetRequest<WeChatPayBillTradeBillResponse>
    {
        /// <summary>
        /// 账单日期
        /// 格式YYYY-MM-DD
        /// 仅支持三个月内的账单下载申请。
        /// 示例值：2019-06-11
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 二级商户号
        /// 1、若商户是直连商户：无需填写该字段。
        /// 2、若商户是服务商：
        /// ● 不填则默认返回服务商下的交易或退款数据。
        /// ● 如需下载某个子商户下的交易或退款数据，则该字段必填。
        /// 特殊规则：最小字符长度为8
        /// 注意：仅适用于电商平台 服务商
        /// 示例值：1900000001
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 账单类型
        /// 不填则默认是ALL
        /// 枚举值：
        /// ALL：返回当日所有订单信息（不含充值退款订单）
        /// SUCCESS：返回当日成功支付的订单（不含充值退款订单）
        /// REFUND：返回当日退款订单（不含充值退款订单）
        /// 示例值：ALL
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 压缩类型
        /// 不填则默认是数据流
        /// 枚举值：
        /// GZIP：返回格式为.gzip的压缩包账单
        /// 示例值：GZIP
        /// </summary>
        public string TarType { get; set; }

        public string GetRequestUrl()
        {
            return $"{$"https://api.mch.weixin.qq.com/v3/bill/tradebill?bill_date={BillDate}"}{(string.IsNullOrEmpty(SubMchId) ? string.Empty : $"&sub_mchid={SubMchId}")}{(string.IsNullOrEmpty(BillType) ? string.Empty : $"&bill_type={BillType}")}{(string.IsNullOrEmpty(TarType) ? string.Empty : $"&tar_type={TarType}")}";
        }
    }
}
