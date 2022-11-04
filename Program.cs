using System.Text.RegularExpressions;

Console.WriteLine($".NET Core \n- Commit Hash: {args[0]} \n - Author: {args[1]} \n - Message: {args[2]}");
Console.WriteLine(GetJiraIssue(args[2]));


static string GetJiraIssue(string message) {
    var regex = new Regex(@"[A-Z]{2,}-\d+");
    var match = regex.Match(message);
    if (match.Success) {
        return match.Value;
    } else {
        return "";
    }
}
