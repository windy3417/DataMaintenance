using DataMaintenance.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataMaintenance.GlobeVary
{

    /// <summary>
    /// Save the information of the  login user and display it in the status bar of the main form
    /// </summary>
 public   static class CurrentUser
    {

        public static  event EventHandler authorizPass;

        /// <summary>
        /// 事件处理方法,调用端实例化事件委托后就执行该方法
        /// authorizPass?本质上相当于执行方法时的第二次判断
        /// 引发事件是执行事件处理方法的第一次判断
        /// </summary>
        /// <param name="authorizationEventArgs"></param>
        static  void onAuthorizPass(EventArgs e)
        {
            authorizPass?.Invoke(userID, e);
        }

      static string _userID;

        

        public static string userID { 
            get {
                return _userID;
            } 
            set {
                if (_userID==value)
                {
                    return;
                }
                _userID = value;
                onAuthorizPass(EventArgs.Empty);
            }
        }
        public static string pwd { get; set; }
        public static string userName { get; set; }

    }
}
