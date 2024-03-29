﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MS_Control.TSDD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;
    using BF = System.Reflection.BindingFlags;

    public static class CopyEventsHandlersExtensionMethods
    {
        public static void CopyTo(this Dictionary<string, Dictionary<object, Delegate[]>> handlers, object destination)
        {
            var helper = new CopyEventHandlers();
            foreach (var eventName in handlers.Keys)
            {
                var innerKeyFieldName = helper.KeyEventNameMapping.First(x => x.Value == eventName).Key;

                var info = typeof(object).GetField(innerKeyFieldName,
                    BF.GetField | BF.Static | BF.NonPublic | BF.DeclaredOnly);

                if (info != null)
                {
                    var innerKeyFieldVal = info.GetValue(destination);

                    var targetType = destination.GetType();
                    var targetEventsInfo = targetType.GetProperty("Events", BF.Instance | BF.NonPublic);
                    var targetEventHandlerList = (EventHandlerList)targetEventsInfo.GetValue(destination, null);

                    var delegates = handlers[eventName].First().Value;
                    foreach (var @delegate in delegates)
                    {
                        targetEventHandlerList.AddHandler(innerKeyFieldVal, @delegate);
                    }
                }
            }
        }
    }
}
