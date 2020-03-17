namespace Essensoft.AspNetCore.Payment.Alipay.Parser
{
    /// <summary>
    /// Alipay API响应解释器接口。响应格式可以是XML, JSON等等。
    /// </summary>
    /// <typeparam name="T">领域对象</typeparam>
    public interface IAlipayParser<T> where T : AlipayResponse
    {
        /// <summary>
        /// 把响应字符串解释成相应的领域对象。
        /// </summary>
        /// <param name="body">响应字符串</param>
        /// <returns>领域对象</returns>
        T Parse(string body);

        /// <summary>
        /// 解析签名内容
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        SignItem GetSignItem(IAlipayRequest<T> request, string body);

        /// <summary>
        /// 解析证书以及签名内容
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        CertItem GetCertItem(IAlipayRequest<T> request, string body);

        /// <summary>
        /// 将响应串解密
        /// </summary>
        /// <param name="request"></param>
        /// <param name="body"></param>
        /// <param name="encryptType"></param>
        /// <param name="encryptKey"></param>
        string EncryptSourceData(IAlipayRequest<T> request, string body, string encryptType, string encryptKey);
    }
}
