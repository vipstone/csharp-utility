using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 时间工具类
/// </summary>
class TimeUtility
{
	/// <summary>
	/// 获取当前时间-时间戳
	/// </summary>
	/// <returns></returns>
	public static int GetNowTimeStamp()
	{
		DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
		return (int)(DateTime.Now - startTime).TotalSeconds;
	}

	/// <summary>
	/// 获取当前本地时间
	/// </summary>
	/// <returns></returns>
	public static DateTime GetNowLocalTime()
	{
		return DateTime.Now;
	}

	/// <summary>
	/// DateTime对象转换为时间戳（10位精确到秒）
	/// </summary>
	/// <param name="time">DateTime对象</param>
	/// <returns></returns>
	public static int GetTimeStamp(DateTime time)
	{
		DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
		return (int)(time - startTime).TotalSeconds;
	}

	/// <summary>
	/// 获取本地时间格式；示例：yyyy-MM-dd HH:mm:ss
	/// </summary>
	/// <param name="timeStamp"></param>
	/// <returns></returns>
	public static DateTime GetLocalTime(string timeStamp)
	{
		DateTime timeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
		TimeSpan timeSpan = new TimeSpan((long.Parse(timeStamp + "0000000")));
		return timeStart.Add(timeSpan);
	}

	/// <summary>
	/// 格式化本地时间
	/// </summary>
	/// <param name="localTime">本地时间</param>
	/// <param name="format">格式化字符串；示例：yyyy-MM-dd HH:mm:ss</param>
	/// <returns></returns>
	public static string FormatLocalTime(DateTime localTime, string format)
	{
		return localTime.ToString(format);
	}

}

