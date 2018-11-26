using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 统一签约创单
    /// </summary>
    public class LianLianPayUnifiedCardBindRequest : ILianLianPayRequest<LianLianPayUnifiedCardBindResponse>
    {
        /// <summary>
        /// 平台来源标识。
        /// 定义用户来源，可以使多个商户号共享一套用户信息，使用前请联系连连技术支持部以确定您的商户号是否满足相关配置条件。
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 用户编号。
        /// 商户系统内对用户的唯一编码，可以为自定义字符串，加密密文或者邮箱等可以唯一定义用户的标识。
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 商户订单号。
        /// 为商户系统内对订单的唯一编号，保证唯一。
        /// 连连会根据NoOrder 创建连连订单号 OidPaybill，如NoOrder已有对应连连订单号 OidPaybill，则将请求视为重复订单请求。
        /// 重复发起订单请求时，请求中的参数信息需与原创单时一致。
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 商户订单时间。
        /// 格式为 YYYYMMddHHmmss，HH以24小时为准，如 20180130161010。
        /// </summary>
        public string DtOrder { get; set; }

        /// <summary>
        /// 接收异步通知的线上地址。
        /// 连连支付支付平台在用户支付成功后通知商户服务端的地址。
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 支付结束后，连连会将消费者重定向至此地址。
        /// </summary>
        public string UrlReturn { get; set; }

        /// <summary>
        /// 传入后在收银台页面激活返回按钮，用户点击返回后跳转向该地址。
        /// 如不传则返回按钮不显示。
        /// </summary>
        public string BackUrl { get; set; }

        /// <summary>
        /// 风险控制参数。
        /// 连连风控部门要求商户统一传入风险控制参数字段，字段值为json 字符串的形式。
        /// 传入示例及要求见风险控制说明。
        /// </summary>
        public string RiskItem { get; set; }

        /// <summary>
        /// 支付产品标识。
        /// 0，快捷收款。
        /// 1，认证收款。
        /// 2，网银收款。
        /// 5，新认证收款。
        /// 12，手机网银收款。
        /// </summary>
        public string FlagPayProduct { get; set; }

        /// <summary>
        /// 应用渠道标识。
        /// 0，App-Android。
        /// 1，App-iOS。
        /// 2，Web。
        /// 3，H5。
        /// 注意: 当FlagPayProduct为12（即手机银行APP支付时）, FlagChnl仅支持传入0或1。
        /// </summary>
        public string FlagChnl { get; set; }

        /// <summary>
        /// 证件类型。
        /// 0，身份证或企业经营证件。
        /// 1，户口簿。
        /// 2，护照。
        /// 3，军官证。
        /// 4，士兵证。
        /// 5，港澳居民来往内地通行证。
        /// 6，台湾同胞来往内地通行证。
        /// 7，临时身份证 
        /// 8，外国人居住证。
        /// 9，警官证。
        /// 10，组织机构代码
        /// X，其他证件。
        /// 目前仅支持身份证，不传则默认为身份证。
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// 证件号码。对应IdType的相关证件号码。
        /// </summary>
        public string IdNo { get; set; }

        /// <summary>
        /// 用户姓名，为用户在银行预留的姓名信息，中文。
        /// 对于少数民族，间隔号以「·」（U+00B7 MIDDLE DOT）为准。
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 用户银行卡卡号。
        /// </summary>
        public string CardNo { get; set; }

        #region ILianLianPayRequest

        private string Version = "1.0";

        public string GetRequestUrl()
        {
            return "https://payserverapi.lianlianpay.com/v1/paycreatebill";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "api_version", Version },
                { "platform", Platform },
                { "user_id", UserId },
                { "no_order", NoOrder },
                { "dt_order", DtOrder },
                { "notify_url", NotifyUrl },
                { "url_return", UrlReturn },
                { "back_url", BackUrl },
                { "risk_item", RiskItem },
                { "flag_pay_product", FlagPayProduct },
                { "flag_chnl", FlagChnl },
                { "id_type", IdType },
                { "id_no", IdNo },
                { "acct_name", AcctName },
                { "card_no", CardNo }
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
