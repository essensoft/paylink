using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayPaymentRequest : ILianLianPayRequest<LianLianPayPaymentResponse>
    {
        /// <summary>
        /// 平台来源
        /// 平台来源能有效区分该交易是从此平台发起，并能有效定义用户来源。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 商户付款流水号
        /// 商户系统唯一标识该付款的流水号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户付款时间
        /// 格式：YYYYMMDDH24MISS 14 位数字，精确到秒
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 付款金额
        /// 付款金额，单位为元，精确到小数点后两位。如：49.65 元
        /// </summary>
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 收款银行账号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 收款人姓名
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 收款银行名称
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 订单描述
        /// 付款用途
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 对公对私标志
        /// 0-对私 1-对公
        /// </summary>
        public string FlagCard { get; set; }

        /// <summary>
        /// 服务器异步通知地址
        /// 连连支付平台在付款后通知商户服务端的地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 收款备注
        /// 传递至银行，特殊字符会过滤掉不传递至银行，单 个 字 符 过 滤 规 则 正 则 表达式 ：[^a-zA-Z0-9\\u4e00-\\u9fa5-_]
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 大额行号
        /// 对公字段，若传，则省市支行可不传，且大额行号以此为准
        /// </summary>
        public string Prcptcd { get; set; }

        /// <summary>
        /// 银行编码
        /// 对公字段，见银行编码 对公 bank_code 必传
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 开户行所在市编码
        /// 对公字段，标准地市编码 26 家银行可不传 详情请看银行列表
        /// </summary>
        public string CityCode { get; set; }

        /// <summary>
        /// 开户支行名称
        /// 对公字段 26 家银行可不传 详情请看银行列表
        /// </summary>
        public string BrabankName { get; set; }

        #region ILianLianPayRequest
        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://instantpay.lianlianpay.com/paymentapi/payment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "money_order", MoneyOrder },
                { "card_no", CardNo },
                { "acct_name", AcctName },
                { "bank_name", BankName },
                { "info_order", InfoOrder },
                { "flag_card", FlagCard },
                { "notify_url", NotifyUrl },
                { "memo", Memo },
                { "prcptcd", Prcptcd },
                { "bank_code", BankCode },
                { "city_code", CityCode },
                { "brabank_name", BrabankName },
                { "api_version", ApiVersion },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }
        #endregion
    }
}
