using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 车主平台 - 申请扣款 (普通商户)
    /// </summary>
    public class WeChatPayVehiclePayPayApplyRequest : IWeChatPayRequest<WeChatPayVehiclePayPayApplyResponse>
    {
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
        public int FeeType { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public int SpBillCreateIp { get; set; }

        /// <summary>
        /// 商品标记
        /// </summary>
        public int GoodsTag { get; set; }

        /// <summary>
        /// 回调通知url
        /// </summary>
        public int NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public int TradeType { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 交易场景
        /// </summary>
        public string TradeScene { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        public string SceneInfo { get; set; }


        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/vehicle/pay/payapply";

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
                { "body", Body },
                { "detail", Detail },
                { "attach", Attach },
                { "out_trade_no", OutTradeNo },
                { "total_fee", TotalFee },
                { "fee_type", FeeType },
                { "spbill_create_ip", SpBillCreateIp },
                { "goods_tag", GoodsTag },
                { "notify_url", NotifyUrl },
                { "trade_type", TradeType },
                { "version", Version },
                { "trade_scene", TradeScene },
                { "scene_info", SceneInfo },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
