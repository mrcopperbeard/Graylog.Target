#region Usings

using System;

using Newtonsoft.Json.Linq;

using NLog;

#endregion

namespace Graylog.Target
{
	/// <summary>
	/// Конвертер событий логирования в объекты JSON.
	/// </summary>
	public interface IConverter
	{
		/// <summary>
		/// Возвращает объект созданный из сообщения.
		/// </summary>
		/// <param name="logEventInfo">Информация о сообщении.</param>
		/// <param name="facility">Значение настройки facility.</param>
		/// <returns>Объект для сериализации.</returns>
		JObject GetGelfJson(LogEventInfo logEventInfo, string facility);
	}
}