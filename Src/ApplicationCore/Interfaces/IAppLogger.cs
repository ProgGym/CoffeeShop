namespace ProgGym.CoffeeShop.ApplicationCore.Interfaces;
interface IAppLogger
{
    void LogInformation(string messange, params object[] args);
    void LogWarning(string messange, params object[] args);
    void LogError(string messange, params object[] args);
}