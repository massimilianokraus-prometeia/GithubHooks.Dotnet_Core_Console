@echo
dotnet run --project ./GithubHooks.Dotnet_Core_Console -- "${{ github.sha }}" "${{ github.actor }}" "${{ github.event.head_commit.message }}"
exit
