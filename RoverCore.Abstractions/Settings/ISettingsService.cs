namespace RoverCore.Abstractions.Settings;

public interface ISettingsService<T>
{
    /// <summary>
    /// Loads persisted settings from database
    /// </summary>
    /// <returns></returns>
    Task LoadPersistedSettings();

    /// <summary>
    /// Returns the settings service singleton reference
    /// </summary>
    /// <returns></returns>
    T GetSettings();

    /// <summary>
    /// Saves the existing application settings to the database
    /// </summary>
    /// <returns></returns>
    Task SaveSettings();

    /// <summary>
    /// Copies the values for each property in settings to the ApplicationSettings singleton and saves a copy in the database
    /// </summary>
    /// <param name="newSettings"></param>
    /// <returns></returns>
    Task PatchSettings(T newSettings);
}