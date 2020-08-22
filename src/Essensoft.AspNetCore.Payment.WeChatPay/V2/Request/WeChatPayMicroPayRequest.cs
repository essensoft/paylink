using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 提交刷卡支付 (普通商户 / 服务商)
    /// </summary>
    public class WeChatPayMicroPayRequest : IWeChatPayRequest<WeChatPayMicroPayResponse>
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
        /// 总金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 货币类型
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpBillCreateIp { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        public string GoodsTag { get; set; }

        /// <summary>
        /// 指定支付方式
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public string TimeExpire { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        public string SceneInfo { get; set; }

        /// <summary>
        /// 是否指定服务商分账
        /// </summary>
        public string ProfitSharing { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/micropay";

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
                { "goods_tag", GoodsTag },
                { "limit_pay", LimitPay },
                { "time_start", TimeStart },
                { "time_expire", TimeExpire },
                { "auth_code", AuthCode },
                { "scene_info", SceneInfo },
                { "profit_sharing", ProfitSharing }
            };
            return parameters;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
