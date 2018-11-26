using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 统一支付创单
    /// </summary>
    public class LianLianPayCreateBillRequest : ILianLianPayRequest<LianLianPayCreateBillResponse>
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
        /// 商户商品名称。
        /// 建议传入真实商品名称。
        /// </summary>
        public string NameGoods { get; set; }

        /// <summary>
        /// 订单扩展字段。
        /// 透传参数传于此字段，支付成功后连连会将InfoOrder附在异步通知中返回。
        /// </summary>
        public string InfoOrder { get; set; }

        /// <summary>
        /// 交易金额。
        /// 请求NoOrder对应的订单总金额，单位为元，精确到小数点后两位，小数点计入字符长度。
        /// 取值范围为 0.01 ~ 99999999。
        /// </summary>
        public string MoneyOrder { get; set; }

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
        /// 订单有效期。
        /// 订单创建后，开始计时，以分钟为单位，不传默认为10080 (7天)，建议赋值范围为 120 ~ 10080。
        /// 超过订单有效期未被支付的订单会被置为关闭状态，不可再次以该单号发起支付申请。
        /// 当订单进入掉单判定逻辑时，订单有效期会被延长，详见订单状态说明。
        /// </summary>
        public string ValidOrder { get; set; }

        /// <summary>
        /// 分账信息。
        /// 用于有分账需求的交易。
        /// 传入示例及要求见分账说明。
        /// </summary>
        public string ShareingData { get; set; }

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
        /// 注意
        /// 使用支付产品认证收款及新认证收款时IdType为必传字段。
        /// 默认为0，且目前仅支持0。历次支付时，传入NoAgree则IdType为可选参数，两者都传时，以NoAgree为准。
        /// </summary>
        public string IdType { get; set; }

        /// <summary>
        /// 证件号码。对应IdType的相关证件号码。
        /// 注意
        /// 使用支付产品认证收款及新认证收款时IdNo为必传字段。
        /// 历次支付时，传入NoAgree则IdNo为可选参数，两者都传时，以NoAgree为准。
        /// </summary>
        public string IdNo { get; set; }

        /// <summary>
        /// 用户姓名，为用户在银行预留的姓名信息，中文。
        /// 对于少数民族，间隔号以「·」（U+00B7 MIDDLE DOT）为准。
        /// 注意
        /// 使用支付产品认证收款及新认证收款时acct_name为必传字段。
        /// 历次支付时，传入NoAgree则AcctName为可选参数，两者都传时，以NoAgree为准。
        /// </summary>
        public string AcctName { get; set; }

        /// <summary>
        /// 用户银行卡卡号。
        /// 历次支付时，传入NoAgree则取该协议号对应的用户银行卡号，两者都传时，以NoAgree为准。
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 签约协议编号。
        /// 签约规则及详情见签约说明。
        /// </summary>
        public string NoAgree { get; set; }

        /// <summary>
        /// 银行编码。
        /// 指定银行编号后，可直接跳转指定银行网银或手机银行APP收银台(若此参数为非空，则CardType必填)。
        /// </summary>
        public string BankCode { get; set; }

        /// <summary>
        /// 卡类型。
        /// 适用于网银支付和手机银行支付。
        /// 0，借记卡。
        /// 1，信用卡。
        /// 2，企业网银。(若此参数为非空，则BankCode必填。)
        /// </summary>
        public string CardType { get; set; }

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
                { "name_goods", NameGoods },
                { "info_order", InfoOrder },
                { "money_order", MoneyOrder },
                { "notify_url", NotifyUrl },
                { "url_return", UrlReturn },
                { "back_url", BackUrl },
                { "valid_order", ValidOrder },
                { "shareing_data", ShareingData },
                { "risk_item", RiskItem },
                { "flag_pay_product", FlagPayProduct },
                { "flag_chnl", FlagChnl },
                { "id_type", IdType },
                { "id_no", IdNo },
                { "acct_name", AcctName },
                { "card_no", CardNo },
                { "no_agree", NoAgree },
                { "bank_code", BankCode },
                { "card_type", CardType }
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
