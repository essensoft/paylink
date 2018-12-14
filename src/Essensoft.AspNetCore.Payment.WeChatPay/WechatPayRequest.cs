using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// 微信支付请求类的一些公用实现
    /// </summary>
    public abstract class WechatPayRequest<T> : WeChatRequestBase, IWeChatPayRequest<T> where T : WeChatPayResponse
    {
        /// <summary>
        /// 处理配置选项中的参数和通用参数
        /// </summary>
        /// <param name="sortedTxtParams">参数集合</param>
        /// <param name="options">配置选项</param>
        protected override void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(ConstKey.Key_mch_id, options.MchId);
            sortedTxtParams.Add(ConstKey.Key_nonce_str, Guid.NewGuid().ToString("N"));

            if (string.IsNullOrEmpty(sortedTxtParams.GetValue(ConstKey.Key_appid)))
            {
                sortedTxtParams.Add(ConstKey.Key_appid, options.AppId);
            }
        }
        /// <summary>
        /// 处理签名
        /// 默认按md5进行签名计算，并且计算参数中不包含sign_type字段
        /// 如果子类的实际情况与此不符，请重写此方法
        /// </summary>
        /// <param name="sortedTxtParams">参数集合</param>
        /// <param name="options">配置选项</param>
        protected override void HandleSign(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options)
        {
            sortedTxtParams.Add(ConstKey.Key_sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, true, true));

        }
    }
}
