namespace LeetcodeConsole
{
    internal interface IMenuItem
    {
        string Key { get; }
        string Display { get; }
        Action Action { get; }
    }
}
