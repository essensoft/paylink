using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 请求接口
    /// </summary>
    public interface IAlipayRequest<T> where T : AlipayResponse
    {
        /// <summary>
        /// 获取Alipay的异步通知地址
        /// </summary>
        string GetNotifyUrl();

        /// <summary>
        /// 设置Alipay的异步通知地址
        /// </summary>
        void SetNotifyUrl(string notifyUrl);

        /// <summary>
        /// 获取Alipay的同步通知地址
        /// </summary>
        string GetReturnUrl();

        /// <summary>
        /// 设置Alipay的同步通知地址
        /// </summary>
        void SetReturnUrl(string returnUrl);

        /// <summary>
        /// 设置请求是否需要加密
        /// </summary>
        void SetNeedEncrypt(bool needEncrypt);

        /// <summary>
        /// 获取Alipay请求是否需要加密
        /// </summary>
        bool GetNeedEncrypt();

        /// <summary>
        /// 获取Alipay的API名称
        /// </summary>
        string GetApiName();

        /// <summary>
        /// 获取终端类型
        /// </summary>
		string GetTerminalType();

        /// <summary>
        /// 设置终端类型
        /// </summary>
		void SetTerminalType(string terminalType);

        /// <summary>
        /// 获取终端信息
        /// </summary>
		string GetTerminalInfo();

        /// <summary>
        /// 设置终端信息
        /// </summary>
		void SetTerminalInfo(string terminalInfo);

        /// <summary>
        /// 获取产品码
        /// </summary>
        string GetProdCode();

        /// <summary>
        /// 设置产品码
        /// </summary>
        void SetProdCode(string prodCode);

        /// <summary>
        /// 设置接口版本
        /// </summary>
        void SetApiVersion(string apiVersion);

        /// <summary>
        /// 返回接口版本
        /// </summary>
        string GetApiVersion();

        /// <summary>
        /// 获取文本请求参数字典
        /// </summary>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 获取BizModel
        /// </summary>
        AlipayObject GetBizModel();

        /// <summary>
        /// 设置BizModel
        /// </summary>
        /// <param name="bizModel"></param>
        void SetBizModel(AlipayObject bizModel);
    }
}
