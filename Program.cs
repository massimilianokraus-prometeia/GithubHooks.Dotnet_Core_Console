using System.Text.RegularExpressions;

class Program
{
    static string Main(string[] args) {
        Console.WriteLine($".NET Core App Started \n - Pull Request Title: {args[0]} \n - Pull Request Body: {args[1]}");
        // Console.WriteLine(GetJiraIssue(args[0]));
        return GetJiraIssue(args[0]);

        static string GetJiraIssue(string message) {
            var regex = new Regex(@"[A-Z]{2,}-\d+");
            var match = regex.Match(message);
            if (match.Success) {
                return match.Value;
            } else {
                return "";
            }
        }
    }
}
