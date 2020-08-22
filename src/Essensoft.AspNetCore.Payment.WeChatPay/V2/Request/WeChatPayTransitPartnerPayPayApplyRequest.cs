using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 乘车码代扣 - 申请扣款 (服务商)
    /// </summary>
    public class WeChatPayTransitPartnerPayPayApplyRequest : IWeChatPayRequest<WeChatPayTransitPartnerPayPayApplyResponse>
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
        /// 委托代扣协议id
        /// </summary>
        public int ContractId { get; set; }

        /// <summary>
        /// 交易场景
        /// </summary>
        public string TradeScene { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        public string SceneInfo { get; set; }

        /// <summary>
        /// 是否指定服务商分账
        /// </summary>
        public string ProfitSharing { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/vehicle/partnerpay/payapply";

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
                { "contract_id", ContractId },
                { "trade_scene", TradeScene },
                { "scene_info", SceneInfo },
                { "profit_sharing", ProfitSharing }
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
            sortedTxtParams.Add(WeChatPayConsts.sub_appid, options.SubAppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);
            sortedTxtParams.Add(WeChatPayConsts.sub_mch_id, options.SubMchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        #endregion
    }
}
