using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 账单-申请资金账单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2019.09.16
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/bill/chapter3_2.shtml
    /// </summary>
    public class WeChatPayBillFundflowBillRequest : IWeChatPayGetRequest<WeChatPayBillFundflowBillResponse>
    {
        /// <summary>
        /// 账单日期
        /// 格式YYYY-MM-DD
        /// 仅支持三个月内的账单下载申请。
        /// 示例值：2019-06-11
        /// </summary>
        public string BillDate { get; set; }

        /// <summary>
        /// 资金账户类型
        /// 不填则默认是BASIC
        /// 枚举值：
        /// BASIC：基本账户
        /// OPERATION：运营账户
        /// FEES：手续费账户
        /// 示例值：BASIC
        /// </summary>
        public string AccountType { get; set; }

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
            return $"{$"https://api.mch.weixin.qq.com/v3/bill/fundflowbill?bill_date={BillDate}"}{(string.IsNullOrEmpty(AccountType) ? string.Empty : $"&account_type={AccountType}")}{(string.IsNullOrEmpty(TarType) ? string.Empty : $"&tar_type={TarType}")}";
        }
    }
}
