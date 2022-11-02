@echo
dotnet run -- "${{ github.sha }}" "${{ github.actor }}" "${{ github.event.head_commit.message }}"
exit
