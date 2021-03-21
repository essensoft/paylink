using System.Collections.Generic;
using Essensoft.Paylink.WeChatPay.V2.Response;

namespace Essensoft.Paylink.WeChatPay.V2.Request
{
    /// <summary>
    /// 酒店押金 - 支付押金 - JSAPI下单、APP支付 (服务商)
    /// </summary>
    public class WeChatPayDepositUnifiedorderRequest : IWeChatPayRequest<WeChatPayDepositUnifiedorderResponse>
    {
        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpBillCreateIp { get; set; }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public string TimeExpire { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 指定支付方式
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// 用户标识
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// 用户子标识
        /// </summary>
        public string SubOpenId { get; set; }

        /// <summary>
        /// 电子发票入口开放标识
        /// </summary>
        public string Receipt { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        public string SceneInfo { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/deposit/unifiedorder";
        private WeChatPaySignType signType = WeChatPaySignType.HMAC_SHA256;

        public string GetRequestUrl()
        {
            return requestUrl;
        }

        public void SetRequestUrl(string url)
        {
            requestUrl = url;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "device_info", DeviceInfo },
                { "body", Body },
                { "detail", Detail },
                { "attach", Attach },
                { "out_trade_no", OutTradeNo },
                { "total_fee", TotalFee },
                { "fee_type", FeeType },
                { "spbill_create_ip", SpBillCreateIp },
                { "time_start", TimeStart },
                { "time_expire", TimeExpire },
                { "notify_url", NotifyUrl },
                { "trade_type", TradeType },
                { "product_id", ProductId },
                { "limit_pay", LimitPay },
                { "openid", OpenId },
                { "sub_openid", SubOpenId },
                { "receipt", Receipt },
                { "scene_info", SceneInfo },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return signType;
        }

        public void SetSignType(WeChatPaySignType signType)
        {
            this.signType = signType;
        }

        public void PrimaryHandler(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign_type, signType.ToString());
            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.APIKey, signType));
        }

        #endregion
    }
}
