// ***********************************************************************
// Assembly         : OpenAuth.App
// Author           : yubaolee
// Created          : 07-08-2016
//
// Last Modified By : yubaolee
// Last Modified On : 07-08-2016
// Contact : Microsoft
// File: AuthUtil.cs
// ***********************************************************************


using System;
using System.Configuration;
using System.Web;
using Infrastructure;
using MVC.App.Response;

namespace MVC.App.SSO
{
    /// <summary>
    /// ��������վ��¼��֤��
    /// <para>��¼ʱ��</para>
    /// <code>
    ///  var result = AuthUtil.Login(AppKey, username, password);
    ///  if (result.Success)
    ///       return Redirect("/home/index?Token=" + result.Token);
    /// </code>
    /// </summary>
    public class AuthUtil
    {
        static HttpHelper _helper = new HttpHelper(ConfigurationManager.AppSettings["SSOPassport"]);

        private static string GetToken()
        {
            string token = HttpContext.Current.Request.QueryString["Token"];
            if (!String.IsNullOrEmpty(token)) return token;

            var cookie = HttpContext.Current.Request.Cookies["Token"];
            return cookie == null ? String.Empty : cookie.Value;
        }

        public static bool CheckLogin(string token, string remark = "")
        {
            if (String.IsNullOrEmpty(token) || String.IsNullOrEmpty(GetToken()))
                return false;

            var requestUri = String.Format("/api/Check/GetStatus?token={0}&requestid={1}", token, remark);

            try
            {
                var value = _helper.Get(null, requestUri);
                var result = JsonHelper.Instance.Deserialize<Response<bool>>(value);
                if (result.Code == 200)
                {
                    return result.Result;
                }
                throw new Exception(result.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ����û���¼״̬
        /// <para>ͨ��URL�е�Token������Cookie�е�Token</para>
        /// </summary>
        /// <param name="remark">��ע��Ϣ</param>
        public static bool CheckLogin(string remark="")
        {
            return CheckLogin(GetToken(), remark);
        }

        /// <summary>
        /// ��ȡ��ǰ��¼���û���Ϣ
        /// <para>ͨ��URL�е�Token������Cookie�е�Token</para>
        /// </summary>
        /// <param name="remark">The remark.</param>
        /// <returns>LoginUserVM.</returns>
        public static UserWithAccessedCtrls GetCurrentUser(string remark = "")
        {

            var requestUri = String.Format("/api/Check/GetUser?token={0}&requestid={1}", GetToken(), remark);

            try
            {
                var value = _helper.Get(null, requestUri);
                var result = JsonHelper.Instance.Deserialize<Response<UserWithAccessedCtrls>>(value);
                if (result.Code == 200)
                {
                    return result.Result;
                }
                throw new Exception(result.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// ��ȡ��ǰ��¼���û���
        /// <para>ͨ��URL�е�Token������Cookie�е�Token</para>
        /// </summary>
        /// <param name="remark">The remark.</param>
        /// <returns>System.String.</returns>
        public static string GetUserName(string remark = "")
        {
            var requestUri = String.Format("/api/Check/GetUserName?token={0}&requestid={1}", GetToken(), remark);

            try
            {
                var value = _helper.Get(null, requestUri);
                var result = JsonHelper.Instance.Deserialize<Response<string>>(value);
                if (result.Code == 200)
                {
                    return result.Result;
                }
                throw new Exception(result.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��¼�ӿ�
        /// </summary>
        /// <param name="appKey">Ӧ�ó���key.</param>
        /// <param name="username">�û���</param>
        /// <param name="pwd">����</param>
        /// <returns>System.String.</returns>
        public static LoginResult Login(string appKey, string username, string pwd)
        {
            var requestUri = "/api/Check/Login";

            try
            {
                var value = _helper.Post(new
                {
                    AppKey = appKey,
                    Account = username,
                    Password = pwd
                }, requestUri);

                var result = JsonHelper.Instance.Deserialize<LoginResult>(value);
                return result;
               
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// ע��
        /// </summary>
        public static bool Logout()
        {
            var token = GetToken();
            if (String.IsNullOrEmpty(token)) return true;

            var requestUri = String.Format("/api/Check/Logout?token={0}&requestid={1}", token, "");

            try
            {
                var value = _helper.Post(null, requestUri);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}