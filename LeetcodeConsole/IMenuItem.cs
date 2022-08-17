namespace LeetcodeConsole
{
    internal interface IMenuItem
    {
        string Key { get; }
        Action Action { get; }
    }
}
