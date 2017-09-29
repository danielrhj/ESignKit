using System.Text;

namespace Foxconn.GLISPLL
{
    public class MD5
    {
        #region 格式化md5 hash 位元組陣列所用的格式（兩位元小寫16進制數位）
        private static readonly string m_strHexFormat = "x2";
        private MD5() { }
        #endregion

        #region 使用當前缺省的字元編碼對字串進行加密
        /// <param name="str">需要進行md5演算的字串</param>
        /// <returns>用小寫字母表示的32位元16進制數位字串</returns>
        public static string md5(string str)
        {
            return (string)md5(str, false, Encoding.Default);
        }
        #endregion

        #region 對字串進行md5 hash計算
        /// <param name="str">需要進行md5演算的字串</param>
        /// <param name="raw_output">
        /// false則返回經過格式化的加密字串(等同於 string md5(string) )
        /// true則返回原始的md5 hash 長度16 的 byte[] 陣列
        /// </param>
        /// <returns>byte[] 陣列或者經過格式化的 string 字串</returns>
        public static object md5(string str, bool raw_output)
        {
            return md5(str, raw_output, Encoding.Default);
        }
        #endregion

        #region 對字串進行md5 hash計算
        /// <param name="str">需要進行md5演算的字串</param>
        /// <param name="raw_output">
        /// false則返回經過格式化的加密字串(等同於 string md5(string) )
        /// true則返回原始的md5 hash 長度16 的 byte[] 陣列
        /// </param>
        /// <param name="charEncoder">
        /// 用來指定對輸入字串進行編解碼的 Encoding 類型，
        /// 當輸入字串中包含多位元組文字（比如中文）的時候
        /// 必須保證進行匹配的 md5 hash 所使用的字元編碼相同，
        /// 否則計算出來的 md5 將不匹配。
        /// </param>
        /// <returns>byte[] 陣列或者經過格式化的 string 字串</returns>
        public static object md5(string str, bool raw_output, Encoding charEncoder)
        {
            if (!raw_output)
                return md5str(str, charEncoder);
            else
                return md5raw(str, charEncoder);
        }
        #endregion

        #region 使用當前缺省的字元編碼對字串進行加密
        /// <param name="str">需要進行md5演算的字串</param>
        /// <returns>用小寫字母表示的32位元16進制數位字串</returns>
        protected static string md5str(string str)
        {
            return md5str(str, Encoding.Default);
        }
        #endregion

        #region 對字串進行md5加密
        /// <param name="str">需要進行md5演算的字串</param>
        /// <param name="charEncoder">指定對輸入字串進行編解碼的 Encoding 類型</param>
        /// <returns>用小寫字母表示的32位元16進制數位字串</returns>
        protected static string md5str(string str, Encoding charEncoder)
        {
            byte[] bytesOfStr = md5raw(str, charEncoder);
            int bLen = bytesOfStr.Length;
            StringBuilder pwdBuilder = new StringBuilder(32);
            for (int i = 0; i < bLen; i++)
            {
                pwdBuilder.Append(bytesOfStr[i].ToString(m_strHexFormat));
            }
            return pwdBuilder.ToString();
        }
        #endregion

        #region 使用當前缺省的字元編碼對字串進行加密
        /// <param name="str">需要進行md5演算的字串</param>
        /// <returns>長度16 的 byte[] 陣列</returns>
        protected static byte[] md5raw(string str)
        {
            return md5raw(str, Encoding.Default);
        }
        #endregion

        #region 對字串進行md5加密
        /// <param name="str">需要進行md5演算的字串</param>
        /// <param name="charEncoder">指定對輸入字串進行編解碼的 Encoding 類型</param>
        /// <returns>長度16 的 byte[] 陣列</returns>
        protected static byte[] md5raw(string str, Encoding charEncoder)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            return md5.ComputeHash(charEncoder.GetBytes(str));
        }
        #endregion
    }
}