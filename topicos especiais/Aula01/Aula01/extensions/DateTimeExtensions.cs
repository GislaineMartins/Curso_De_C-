using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Globalization;

namespace Aula01.extensions {
    static class  DateTimeExtensions {

    public static string ElapsedTime(this DateTime thisObj) {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0) {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }else {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }

    }
    }
}
