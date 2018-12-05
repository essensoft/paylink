using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 请求接口。
    /// </summary>
    public interface IAlipayRequest<T> where T : AlipayResponse
    {
        /// <summary>
        /// 获取Alipay的异步通知地址。
        /// </summary>
        /// <returns>异步通知地址</returns>
        string GetNotifyUrl();

        /// <summary>
        /// 设置Alipay的异步通知地址。
        /// </summary>
        /// <returns>异步通知地址</returns>
        void SetNotifyUrl(string notifyUrl);

        /// <summary>
        /// 获取Alipay的同步通知地址。
        /// </summary>
        /// <returns>异步通知地址</returns>
        string GetReturnUrl();

        /// <summary>
        /// 设置Alipay的同步通知地址。
        /// </summary>
        /// <returns>异步通知地址</returns>
        void SetReturnUrl(string returnUrl);

        /// <summary>
        /// 设置请求是否需要加密
        /// </summary>
        void SetNeedEncrypt(bool needEncrypt);

        /// <summary>
        /// 获取Alipay请求是否需要加密
        /// </summary>
        /// <returns>结果是否加密</returns>
        bool GetNeedEncrypt();

        /// <summary>
        /// 获取Alipay的API名称。
        /// </summary>
        /// <returns>API名称</returns>
        string GetApiName();

        /// <summary>
        /// 获取终端类型。
        /// </summary>
        /// <returns>终端类型</returns>
		string GetTerminalType();

        /// <summary>
        /// 设置终端类型。
        /// </summary>
        /// <returns>终端类型</returns>
		void SetTerminalType(string terminalType);

        /// <summary>
        /// 获取终端信息。
        /// </summary>
        /// <returns>终端信息</returns>
		string GetTerminalInfo();

        /// <summary>
        /// 设置终端信息。
        /// </summary>
        /// <returns>终端信息</returns>
		void SetTerminalInfo(string terminalInfo);

        /// <summary>
        /// 获取产品码。
        /// </summary>
        /// <returns>产品码</returns>
        string GetProdCode();

        /// <summary>
        /// 设置产品码。
        /// </summary>
        /// <returns>产品码</returns>
        void SetProdCode(string prodCode);

        /// <summary>
        /// 设置接口版本
        /// </summary>
        void SetApiVersion(string apiVersion);


        /// <summary>
        /// 返回接口版本
        /// </summary>
        /// <returns>接口版本</returns>
        string GetApiVersion();

        /// <summary>
        /// 获取所有的Key-Value形式的文本请求参数字典。其中：
        /// Key: 请求参数名
        /// Value: 请求参数文本值
        /// </summary>
        /// <returns>文本请求参数字典</returns>
        IDictionary<string, string> GetParameters();

        /// <summary>
        /// 获取BizModel
        /// </summary>
        /// <returns></returns>
        AlipayObject GetBizModel();

        /// <summary>
        /// 设置BizModel
        /// </summary>
        /// <param name="bizModel"></param>
        void SetBizModel(AlipayObject bizModel);
    }
}
