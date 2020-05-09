
## {{namespace}}.HttpClient nuget pipeline: {{dashed-namespace}}-nuget-buildCI.yml

 - This pipeline is manually ran and does the following steps:
	- Restore **Nuget** dependencies
	- **Build** the solution
	- **Pack** the **{{namespace}}.HttpClient** **Nuget** package
	- **Publish** the **{{namespace}}.HttpClient** **Nuget** package to **Azure DevOps**
