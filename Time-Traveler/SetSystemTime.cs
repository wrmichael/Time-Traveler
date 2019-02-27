using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Time_Traveler
{
    class SetAC9HPSystemTime
    {
        [DllImport("kernel32.dll")]
        private extern static void GetSystemTime(ref SYSTEMTIME lpSystemTime);

        [DllImport("kernel32.dll")]
        private extern static uint SetSystemTime(ref SYSTEMTIME lpSystemTime);


        private struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        public  static DateTime GetTime()
        {
            // Call the native GetSystemTime method
            // with the defined structure.
            SYSTEMTIME stime = new SYSTEMTIME();
            GetSystemTime(ref stime);
            return new DateTime(stime.wYear, stime.wMonth, stime.wDay, stime.wHour, stime.wMinute,stime.wSecond,stime.wMilliseconds);

            // Show the current time.           
            //Debug.WriteLine("Current Time: " +
            //    stime.wHour.ToString() + ":"
            //    + stime.wMinute.ToString());
        }
        public static DateTime SetTime(DateTime at,int st)
        {
            DateTime nt = at.ToUniversalTime();
            
            // Call the native GetSystemTime method
            // with the defined structure.
            SYSTEMTIME stime = new SYSTEMTIME();
            //GetSystemTime(ref systime);

            // Set the system clock ahead one hour.
            //systime.wHour (systime.wHour + 1 % 24);

            //TimeSpan span = (DateTime.Now-st);
            nt.AddMilliseconds(st*-1);

            stime.wDay = short.Parse(nt.ToString("dd"));
            stime.wYear = short.Parse(nt.ToString("yyyy"));
            stime.wHour = short.Parse(nt.ToString("HH"));
            stime.wMonth = short.Parse(nt.ToString("MM"));
            stime.wMinute = short.Parse(nt.ToString("mm"));
            stime.wSecond = short.Parse(nt.ToString("ss"));
            stime.wMilliseconds = short.Parse(nt.ToString("fff"));

            SetSystemTime(ref stime);

            return new DateTime(stime.wYear, stime.wMonth, stime.wDay, stime.wHour, stime.wMinute, stime.wSecond, stime.wMilliseconds);

        }


    }
}

