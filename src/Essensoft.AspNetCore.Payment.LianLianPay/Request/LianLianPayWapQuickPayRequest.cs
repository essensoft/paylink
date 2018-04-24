using Essensoft.AspNetCore.Payment.LianLianPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    public class LianLianPayWapQuickPayRequest : ILianLianPayRequest<LianLianPayWapQuickPayResponse>
    {
        /// <summary>
        /// 平台来源标示
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 请求应用标识
        /// </summary>
        public string AppRequest { get; set; }

        /// <summary>
        /// 背景颜色
        /// </summary>
        public string BgColor { get; set; }

        /// <summary>
        /// 字体颜色 
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// 是否主动同步通知标识
        /// </summary>
        public string SyschnotifyFlag { get; set; }

        /// <summary>
        /// 商户唯一订单号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string NameGoods { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string MoneyOrder { get; set; }

        /// <summary>
        /// 异步通知url
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 同步跳转url
        /// </summary>
        public string UrlReturn { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 订单有效时间
        /// </summary>
        public string ValidOrder { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        public string IdNo { get; set; }

        /// <summary>
        /// 银行账号姓名
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 修改标记
        /// </summary>
        public string FlagModify { get; set; }
        /// <summary>
        /// 分账信息数据
        /// </summary>
        public string ShareingData { get; set; }

        /// <summary>
        /// 风险控制参数
        /// </summary>
        public string RiskItem { get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 返回修改信息地址
        /// </summary>
        public string BackUrl { get; set; }

        #region ILianLianPayRequest

        private string Version = "1.1";

        public string GetRequestUrl()
        {
            return "https://wap.lianlianpay.com/payment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "version", Version },
                { "platform", Platform },
                { "user_id", UserId },
                { "app_request", AppRequest },
                { "bg_color", BgColor },
                { "font_color", FontColor },
                { "syschnotify_flag", SyschnotifyFlag },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "name_goods", NameGoods },
                { "info_order", InfoOrder },
                { "money_order", MoneyOrder },
                { "notify_url", NotifyUrl },
                { "url_return", UrlReturn },
                { "no_agree", NoAgree },
                { "valid_order", ValidOrder },
                { "id_type", IdType },
                { "id_no", IdNo },
                { "acct_name", AcctName },
                { "flag_modify", FlagModify },
                { "shareing_data", ShareingData },
                { "risk_item", RiskItem },
                { "card_no", CardNo },
                { "back_url", BackUrl },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return Version;
        }

        public void SetApiVersion(string apiVersion)
        {
            Version = apiVersion;
        }
        #endregion
    }
}
