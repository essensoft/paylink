using Essensoft.AspNetCore.Payment.WeChatPay.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    /// <summary>
    /// 微信支付请求的一些公共实现
    /// </summary>
    public abstract class WeChatRequestBase:IWeChatRequestBase
    {


        /// <summary>
        /// API接口地址,每个请求地址不同，由具体的请求类来实现
        /// </summary>
        /// <returns>API接口地址</returns>
        public abstract string GetRequestUrl();
        /// <summary>
        /// 检查响应中的签名是否正确，不正确则直接抛出异常
        /// </summary>
        /// <param name="response">响应信息</param>
        /// <param name="options">配置信息</param>
        public virtual void CheckResponseSign(WeChatPayResponse response, WeChatPayOptions options)
        {
            //默认为按md5签名方式，并且排除签名类型参数方式进行检查响应中的签名
            DoCheckResponseSign(response, options, true, true);
        }
        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        protected abstract IDictionary<string, string> GetParameters();
        /// <summary>
        /// 处理通用参数，配置选项中的参数和签名
        /// </summary>
        /// <param name="options">配置选项</param>
        /// <returns>可以直接发送给微信的所有参数</returns>
        public WeChatPayDictionary HandleParametersAndSign(WeChatPayOptions options)
        {
            var sortedTxtParams = new WeChatPayDictionary(GetParameters());

            HandleParametersInOptions(sortedTxtParams, options);
            HandleSign(sortedTxtParams, options);

            return sortedTxtParams;
        }
        /// <summary>
        /// 处理配置选项中的参数和通用参数
        /// </summary>
        /// <param name="sortedTxtParams">参数集合</param>
        /// <param name="options">配置选项</param>
        protected abstract void HandleParametersInOptions(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options);
        /// <summary>
        /// 处理签名
        /// 默认按md5进行签名计算，并且计算参数中不包含sign_type字段
        /// 如果子类的实际情况与此不符，请重写此方法
        /// </summary>
        /// <param name="sortedTxtParams">参数集合</param>
        /// <param name="options">配置选项</param>
        protected abstract void HandleSign(WeChatPayDictionary sortedTxtParams, WeChatPayOptions options);

        /// <summary>
        /// 执行响应信息中的签名检查
        /// </summary>
        /// <param name="response">响应信息</param>
        /// <param name="options">配置信息</param>
        /// <param name="useMD5">是否使用md5签名方式</param>
        /// <param name="excludeSignType">是否排除签名类型参数</param>
        protected void DoCheckResponseSign(WeChatPayResponse response, WeChatPayOptions options, bool useMD5 = true, bool excludeSignType = true)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new WeChatPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new WeChatPayException("sign check fail: Parameters is Empty!");
            }

            if (response.Parameters["return_code"] == "SUCCESS")
            {
                //签名只有在返回状态码为Success时才会返回，才需要验证，否则会隐藏掉失败信息，调用方会一直认为是签名错误，实际上可能是缺少其他参数
                if (!response.Parameters.TryGetValue("sign", out var sign))
                {
                    throw new WeChatPayException("sign check fail: sign is Empty!");
                }
                if (!string.IsNullOrEmpty(sign))
                {
                    var cal_sign = WeChatPaySignature.SignWithKey(response.Parameters, options.Key, useMD5, excludeSignType);
                    if (cal_sign != sign)
                    {
                        throw new WeChatPayException("sign check fail: check Sign and Data Fail!");
                    }
                }
            }
        }

    }
}
