using System.Collections.Generic;
using Essensoft.Paylink.Alipay.Utility;

namespace Essensoft.Paylink.Alipay
{
    /// <summary>
    /// Alipay 上传请求接口
    /// </summary>
    public interface IAlipayUploadRequest<T> : IAlipayRequest<T> where T : AlipayResponse
    {
        /// <summary>
        /// 获取文件请求参数字典
        IDictionary<string, FileItem> GetFileParameters();
    }
}
