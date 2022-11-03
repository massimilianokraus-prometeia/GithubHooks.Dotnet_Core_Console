Console.WriteLine($".NET Core \n- Commit Hash: {args[0]} \n - Author: {args[1]} \n - Message: {args[2]}");
Console.WriteLine(GetJiraIssue(args[2]));


static string GetJiraIssue(string message) {
  return "";
}
