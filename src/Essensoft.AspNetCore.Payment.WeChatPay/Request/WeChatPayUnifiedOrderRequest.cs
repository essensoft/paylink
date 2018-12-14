using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 统一下单
    /// </summary>
    public class WeChatPayUnifiedOrderRequest : WechatPayRequest<WeChatPayUnifiedOrderResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

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
        /// 标价币种
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 标价金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 交易起始时间
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        public string TimeExpire { get; set; }

        /// <summary>
        /// 商品标记
        /// </summary>
        public string GoodsTag { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型
        /// JSAPI，NATIVE，APP，MWEB
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
        /// 子用户标识
        /// </summary>
        public string SubOpenId { get; set; }

        /// <summary>
        /// 场景信息
        /// </summary>
        public string SceneInfo { get; set; }

        #region IWeChatPayRequest Members

        public override string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/unifiedorder";
        }

        protected override IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { ConstKey.Key_appid, AppId },
                { ConstKey.Key_sub_appid, SubAppId },
                { ConstKey.Key_sub_mch_id, SubMchId },
                { ConstKey.Key_device_info, DeviceInfo },
                { ConstKey.Key_body, Body },
                { ConstKey.Key_detail, Detail },
                { ConstKey.Key_attach, Attach },
                { ConstKey.Key_out_trade_no, OutTradeNo },
                { ConstKey.Key_fee_type, FeeType },
                { ConstKey.Key_total_fee, TotalFee },
                { ConstKey.Key_spbill_create_ip, SpbillCreateIp },
                { ConstKey.Key_time_start, TimeStart },
                { ConstKey.Key_time_expire, TimeExpire },
                { ConstKey.Key_goods_tag, GoodsTag },
                { ConstKey.Key_notify_url, NotifyUrl },
                { ConstKey.Key_trade_type, TradeType },
                { ConstKey.Key_product_id, ProductId },
                { ConstKey.Key_limit_pay, LimitPay },
                { ConstKey.Key_openid, OpenId },
                { ConstKey.Key_sub_openid, SubOpenId },
                { ConstKey.Key_scene_info, SceneInfo }
            };
            return parameters;
        }

        #endregion
    }
}
