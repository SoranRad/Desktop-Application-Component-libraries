using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gma.System.MouseKeyHook;

namespace MS_Control.KeyBoardMouseHook
{
    public static class KM_Hooking
    {
        private static IKeyboardMouseEvents m_GlobalHook;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IsAppOrGlobal">True = Application Domain,False= Global Domain</param>
        /// <returns></returns>
        public static IKeyboardMouseEvents GetHooking(bool IsAppOrGlobal)
        {
            return m_GlobalHook ?? 
                (m_GlobalHook = IsAppOrGlobal
                       ? Hook.AppEvents()
                       : Hook.GlobalEvents());
        }

        public static void Destroy()
        {
            m_GlobalHook.Dispose();
            
        }
    }
}
