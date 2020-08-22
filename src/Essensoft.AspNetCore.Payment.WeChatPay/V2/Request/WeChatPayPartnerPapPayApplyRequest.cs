using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.V2.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Request
{
    /// <summary>
    /// 微信代扣 - 申请扣款 (服务商)
    /// </summary>
    public class WeChatPayPartnerPapPayApplyRequest : IWeChatPayRequest<WeChatPayPartnerPapPayApplyResponse>
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
        public string FeeType { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 商品标记
        /// </summary>
        public string GoodsTag { get; set; }

        /// <summary>
        /// 回调通知url
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 委托代扣协议id
        /// </summary>
        public string ContractId { get; set; }

        /// <summary>
        /// 电子发票入口开放标识
        /// </summary>
        public string Receipt { get; set; }

        /// <summary>
        /// 是否指定服务商分账
        /// </summary>
        public string ProfitSharing { get; set; }

        #region IWeChatPayRequest Members

        private string requestUrl = "https://api.mch.weixin.qq.com/pay/partner/pappayapply";

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
                { "spbill_create_ip", SpbillCreateIp },
                { "goods_tag", GoodsTag },
                { "notify_url", NotifyUrl },
                { "trade_type", TradeType },
                { "contract_id", ContractId },
                { "receipt", Receipt },
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
