using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 基础支付 - 申请资金账单API（电商平台、服务商、直连商户）- 请求URL参数
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_7.shtml">JSAPI支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_2_7.shtml">APP支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_3_7.shtml">H5支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_4_7.shtml">Native支付 - 申请资金账单API</a></para>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_5_7.shtml">小程序支付 - 申请资金账单API</a></para>
    /// 最新更新时间：2019.09.16
    /// </summary>
    public class WeChatPayBillFundflowBillQueryModel : WeChatPayObject
    {
        /// <summary>
        /// 账单日期
        /// 格式YYYY-MM-DD
        /// 仅支持三个月内的账单下载申请。
        /// 示例值：2019-06-11
        /// </summary>
        [JsonPropertyName("bill_date")]
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
        [JsonPropertyName("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 压缩类型
        /// 不填则默认是数据流
        /// 枚举值：
        /// GZIP：返回格式为.gzip的压缩包账单
        /// 示例值：GZIP
        /// </summary>
        [JsonPropertyName("tar_type")]
        public string TarType { get; set; }
    }
}
